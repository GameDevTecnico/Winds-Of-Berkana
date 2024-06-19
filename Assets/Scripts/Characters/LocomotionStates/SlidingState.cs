using System.Collections;
using UnityEngine;

public class SlidingState : MonoBehaviour, ILocomotionState
{
    [SerializeField] private float _gravity = 3f;
    [SerializeField] private float _acceleration = 5f;
    [SerializeField] private float _maxSpeed = 10f;
    [SerializeField] private float _deceleration = 5f;
    [SerializeField] private float _rotationSpeed = 10f;
    [SerializeField] private float _animationDelay = 0.1f;
    private CharacterLocomotion _characterLocomotion;

    public void StartState()
    {
        _characterLocomotion.ChangeAnimationState(CharacterAnimation.AnimationState.falling);
        _characterLocomotion.ChangeImediateFallVelocity(_gravity);
        _characterLocomotion.ChangeImediateInputVelocity(Vector3.zero);
    }

    public void StartJump()
    {
    }

    public void StopJump()
    {
    }

    public void Move(Vector2 input)
    {
        _characterLocomotion.Rotate(input, _rotationSpeed, true);
        _characterLocomotion.ChangeInputVelocity(input, _acceleration, _maxSpeed, _deceleration);
    }

    public void Run()
    {

    }

    public void Walk(bool walk)
    {
    }

    public void Fall()
    {
    }

    public void Ground()
    {
        _characterLocomotion.ChangeState<RunningState>();
    }

    public void Tunnel() { }

    private void Awake()
    {
        _characterLocomotion = GetComponent<CharacterLocomotion>();
    }

    public void Break() {}

    public void Slide() {}
}