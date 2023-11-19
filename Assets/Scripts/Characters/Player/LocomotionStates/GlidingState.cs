using UnityEngine;

public class GlidingState : MonoBehaviour, ILocomotionState
{
    [SerializeField] private float _gravity = 3f;
    [SerializeField] private float _maxFallSpeed = 3f;
    [SerializeField] private float _acceleration = 5f;
    [SerializeField] private float _maxSpeed = 10f;
    [SerializeField] private float _deceleration = 5f;
    [SerializeField] private float _rotationSpeed = 10f;
    private bool _walk = false;
    private CharacterLocomotion _characterLocomotion;

    public void StartState()
    {

    }

    public void StartJump()
    {
    }

    public void StopJump()
    {
        _characterLocomotion.ChangeState<FallingState>();
    }

    public void Move()
    {
        _characterLocomotion.Rotate(_rotationSpeed);

        float acceleration = _acceleration;
        float maxSpeed = _maxSpeed;
        float deceleration = _deceleration;

        if (_walk)
        {
            acceleration /= 2;
            maxSpeed /= 2;
            deceleration /= 2;
        }

        Vector3 newVelocity = _characterLocomotion.GetNewHorizontalVelocity(_acceleration, _maxSpeed, _deceleration);
        newVelocity.y = _characterLocomotion.GetNewVerticalSpeed(_gravity, _maxFallSpeed, _gravity);
        _characterLocomotion.CharacterController.Move(newVelocity * Time.deltaTime);
    }

    public void Run()
    {

    }

    public void Walk(bool walk)
    {
        _walk = walk;
    }

    public void Fall()
    {
    }

    public void Ground()
    {
        _characterLocomotion.ChangeState<RunningState>();
    }

    private void Start()
    {
        _characterLocomotion = GetComponent<CharacterLocomotion>();
    }
}