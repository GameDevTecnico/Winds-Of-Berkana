using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    private bool _canMove = true;
    protected CharacterLocomotion CharacterLocomotion;
    protected CharacterAnimation CharacterAnimation;
    protected CharacterController CharacterController;

    public void SetCanMove(bool canMove)
    {
        CharacterController.enabled = canMove;
        CharacterLocomotion.gameObject.SetActive(canMove);
        _canMove = canMove;
    }

    public void Spawn(Transform spawnTransform)
    {
        Debug.Log("Spawning...");
        transform.SetPositionAndRotation(spawnTransform.position, spawnTransform.rotation);
    }

    public void Move(Vector2 input)
    {
        CharacterLocomotion.Input = input;
    }

    public void Run()
    {
        if (_canMove)
        {
            CharacterLocomotion.Run();
        }
    }

    public void Walk(bool walk)
    {
        if (_canMove)
        {
            CharacterLocomotion.Walk(walk);
        }
    }

    // The bool states wether the jump is starting or ending
    public void Jump(bool startedJump)
    {
        if (!_canMove)
        {
            return;
        }

        if (startedJump)
        {
            CharacterLocomotion.StartJump();
        }
        else
        {
            CharacterLocomotion.StopJump();
        }
    }

    public void Push(Vector3 force)
    {
        CharacterLocomotion.ChangePushVelocity(force);
    }

    public void ChangeAnimation(CharacterAnimation.AnimationState animationState)
    {
        CharacterAnimation.ChangeAnimation(animationState);
    }

    private void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.TryGetComponent(out MovingPlatform _))
        {
            if (CharacterController.velocity != Vector3.zero)
            {
                return;
            }
            Physics.ComputePenetration(collider, collider.transform.position, collider.transform.rotation, CharacterController, transform.position, transform.rotation, out Vector3 direction, out float distance);
            CharacterLocomotion.ChangePushVelocity(distance * -direction);
        }
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.TryGetComponent(out MovingPlatform _))
        {
            CharacterLocomotion.ChangePushVelocity(Vector3.zero);
        }
    }

    private void Update()
    {
        Vector3 localVelocity = CharacterLocomotion.InputVelocity;
        Vector2 horizontalVelocity = new(localVelocity.x, localVelocity.z);
        CharacterAnimation.Animator.SetFloat("HorizontalSpeed", horizontalVelocity.magnitude);
    }

    private void Awake()
    {
        CharacterAnimation = GetComponentInChildren<CharacterAnimation>();
        CharacterLocomotion = GetComponentInChildren<CharacterLocomotion>();
        CharacterController = GetComponentInChildren<CharacterController>();
    }
}