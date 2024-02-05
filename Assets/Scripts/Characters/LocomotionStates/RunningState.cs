using System;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class RunningState : MonoBehaviour, ILocomotionState
{
    [SerializeField] private float _acceleration = 5f;
    [SerializeField] private float _maxSpeed = 10f;
    [SerializeField] private float _deceleration = 5f;
    [SerializeField] private float _rotationSpeed = 10f;
    private bool _walk = false;
    private CharacterLocomotion _characterLocomotion;

    public void StartJump()
    {
        _characterLocomotion.ChangeState<JumpingState>();
    }

    public void StopJump()
    {

    }

    public void Move()
    {
        float acceleration = _acceleration;
        float maxSpeed = _maxSpeed;
        float deceleration = _deceleration;
        float rotationSpeed = _rotationSpeed;

        if (_walk)
        {
            acceleration /= 2;
            maxSpeed /= 2;
            deceleration /= 2;
        }

        Vector3 newVelocity = _characterLocomotion.GetNewHorizontalVelocity(acceleration, maxSpeed, deceleration);
        if (newVelocity.magnitude <= _maxSpeed / 2)
        {
            rotationSpeed = 180f;
        }

        _characterLocomotion.Rotate(rotationSpeed * Time.deltaTime, canDo180: true);
        newVelocity.y -= 1f; // So that the CharaterController detects the ground
        _characterLocomotion.NewVelocity += newVelocity * Time.deltaTime;
    }

    public void Run()
    {

    }

    public void Fall()
    {
        _characterLocomotion.ChangeState<FallingState>();
    }

    public void Ground()
    {

    }

    public void Tunnel() { }

    public void Walk(bool walk)
    {
        _walk = walk;
    }

    public void StartState()
    {
        _characterLocomotion.ChangeAnimationState(CharacterAnimation.AnimationState.running);
    }

    private void Awake()
    {
        _characterLocomotion = GetComponent<CharacterLocomotion>();
    }

    public void Break()
    {
    }
}