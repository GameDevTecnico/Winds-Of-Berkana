using System;
using System.Data.Common;
using Cinemachine.Utility;
using TMPro;
using UnityEngine;

public class CharacterLocomotion : MonoBehaviour
{
    public Transform Body;
    public Vector2 Input = Vector2.zero;
    public Transform BasePosition;
    public Vector3 BaseVelocity { get; private set; } = Vector3.zero;
    public Vector3 InputVelocity { get; private set; } = Vector3.zero;
    public Vector3 FallVelocity { get; private set; } = Vector3.zero;
    public CharacterController _controller;
    private CharacterManager _characterManager;
    private ILocomotionState _locomotionState;
    [SerializeField] private TMP_Text _debugText;
    [SerializeField] private float _slideSpeed;

    public void StartJump()
    {
        _locomotionState.StartJump();
    }

    public void StopJump()
    {
        _locomotionState.StopJump();
    }

    public void Run()
    {
        _locomotionState.Run();
    }

    public void Walk(bool walk)
    {
        _locomotionState.Walk(walk);
    }
    public void Tunnel()
    {
        _locomotionState.Tunnel();
    }

    public void ChangeState<T>() where T : MonoBehaviour, ILocomotionState
    {
        _locomotionState = GetComponent<T>();
        _locomotionState.StartState();
    }

    public void ChangeAnimationState(CharacterAnimation.AnimationState animationState)
    {
        _characterManager.ChangeAnimation(animationState);
    }

    public void ChangeBaseVelocity(Vector3 baseVelocity)
    {
        BaseVelocity = baseVelocity;
    }

    public void ChangeInputVelocity(Vector2 input, float acceleration, float maxSpeed, float deceleration)
    {
        // Breaking
        if (input == Vector2.zero && InputVelocity != Vector3.zero)
        {
            Vector3 afterFriction = InputVelocity - deceleration * Time.deltaTime * InputVelocity.normalized;

            if (afterFriction.normalized == InputVelocity.normalized)
            {
                InputVelocity = afterFriction;
            }
            else
            {
                InputVelocity = Vector3.zero;
            }
        }

        if (InputVelocity.magnitude > maxSpeed)
        {
            InputVelocity -= deceleration / 2 * Time.deltaTime * InputVelocity.normalized;
        }
        else if (input != Vector2.zero)
        {
            InputVelocity = Vector3.ClampMagnitude(InputVelocity + acceleration * Time.deltaTime * transform.forward, maxSpeed);
        }
    }

    public void Rotate(Vector2 input, float rotationSpeed, bool canDo180)
    {
        if (input == Vector2.zero)
        {
            return;
        }
        Vector3 newInput = BasePosition.forward * input.y
                        + BasePosition.right * input.x;
        newInput.y = 0;

        Vector2 targetVector = new(newInput.x, newInput.z);
        float targetAngle = Vector2.SignedAngle(targetVector, Vector2.up);

        float newAngle = transform.eulerAngles.y;

        if (InputVelocity == Vector3.zero && canDo180)
        {
            newAngle = targetAngle;
        }
        else if (Mathf.Abs(Vector2.SignedAngle(targetVector, new Vector2(InputVelocity.x, InputVelocity.z))) > 90f)
        {
            newAngle = targetAngle;
            _locomotionState.Break();
        }
        else
        {
            newAngle = Mathf.Round(Mathf.MoveTowardsAngle(newAngle, targetAngle, rotationSpeed * Time.deltaTime));
        }
        transform.rotation = Quaternion.Euler(transform.rotation.x, newAngle, transform.rotation.z);

        // Rotate body
        if (Body.transform.eulerAngles.y != transform.eulerAngles.y)
        {
            float bodyAngle = Body.transform.eulerAngles.y;
            newAngle = Mathf.Round(Mathf.MoveTowardsAngle(bodyAngle, transform.eulerAngles.y, rotationSpeed * Time.deltaTime));
            Body.transform.rotation = Quaternion.Euler(Body.transform.rotation.x, newAngle, Body.transform.rotation.z);
        }
    }


    public void ChangeImediateFallVelocity(float fallSpeed)
    {
        FallVelocity = new(0f, -fallSpeed, 0f);
    }

    public void ChangeFallVelocity(float acceleration)
    {
        float fallSpeed = FallVelocity.y;
        fallSpeed -= acceleration * Time.deltaTime;
        FallVelocity = new(0f, fallSpeed, 0f);
    }

    public void ChangeFallVelocity(float acceleration, float maxSpeed, float deceleration)
    {
        float fallSpeed = FallVelocity.y;
        if (fallSpeed > -maxSpeed)
        {
            fallSpeed = Math.Clamp(fallSpeed - acceleration * Time.deltaTime, -maxSpeed, float.MaxValue);
        }
        else if (fallSpeed < -maxSpeed)
        {
            fallSpeed = Math.Clamp(fallSpeed + deceleration * Time.deltaTime, float.MinValue, -maxSpeed);
        }
        FallVelocity = new(0f, fallSpeed, 0f);
    }

    public void AddJumpForce(float force)
    {
        FallVelocity = new(0f, force, 0f);
    }

    public void StopJumpForce(float force)
    {
        if (FallVelocity.y > 0f)
        {
            float stopForce = FallVelocity.y;
            stopForce = Math.Clamp(stopForce - force, 0f, float.MaxValue);
            FallVelocity = new Vector3(0f, stopForce, 0f);
        }
    }

    private void Update()
    {
        _locomotionState.Move(Input);

        Vector3 horizontalVelocity = InputVelocity;
        float angle = 0;

        if (Physics.SphereCast(transform.position + transform.up * _controller.radius, _controller.radius, transform.up * -1,
         out RaycastHit hit, 0.1f, ~LayerMask.GetMask("Player"), QueryTriggerInteraction.Ignore))
        {
            angle = Vector3.Angle(hit.normal, Vector3.up);
            // Slide
            if (angle > _controller.slopeLimit)
            {
                horizontalVelocity += angle / _controller.slopeLimit * FallVelocity.magnitude * hit.normal.ProjectOntoPlane(Vector3.up);
                _locomotionState.Fall();
            }
            else
            {
                // Uphill
                if (Vector3.SignedAngle(InputVelocity.ProjectOntoPlane(Vector3.up), hit.normal.ProjectOntoPlane(Vector3.up), hit.normal.ProjectOntoPlane(Vector3.up)) > 90f)
                {
                    horizontalVelocity = Vector3.ClampMagnitude(InputVelocity, InputVelocity.magnitude * (_controller.slopeLimit * 1.5f - angle) / _controller.slopeLimit);

                }
                _locomotionState.Ground();
            }
            if (hit.collider.gameObject.TryGetComponent(out MovingPlatform movingPlatform))
            {
                transform.parent.SetParent(movingPlatform.transform);
            }
        }
        else if (_locomotionState != null && _locomotionState is not WindTunnel)
        {
            _locomotionState.Fall();
            transform.parent.SetParent(null);
            ChangeBaseVelocity(Vector3.zero);
        }

        Vector3 velocity = (BaseVelocity + horizontalVelocity + FallVelocity) * Time.deltaTime;

        _controller.Move(velocity);

        LocomotionDebug(angle, horizontalVelocity);
    }

    private void LocomotionDebug(float slope, Vector3 horizontalVelocity)
    {
        string text = "Global Velocity: " + (BaseVelocity + InputVelocity + FallVelocity);
        text += "\nVelocity: " + (InputVelocity + FallVelocity);
        text += "\nInput Velocity: " + InputVelocity;
        text += "\nHorizontal Velocity: " + horizontalVelocity;
        text += "\nFall Velocity: " + FallVelocity;
        text += "\nBase Velocity: " + BaseVelocity;
        text += "\nSlope: " + slope;
        text += "\n" + _locomotionState;

        _debugText.SetText(text);
    }

    private void Start()
    {
        ChangeState<RunningState>();
    }

    private void Awake()
    {
        _characterManager = GetComponentInParent<CharacterManager>();
        _controller = GetComponentInParent<CharacterController>();
    }
}