using System;
using UnityEngine;

public class RunningState : LocomotionState
{
    [SerializeField] private float _jumpForce = 5f;

    public override void StartJump()
    {
        Locomotion.Jump(_jumpForce);
        Locomotion.ChangeState(GetComponent<FallingState>());
    }

    public override void StopJump()
    {
        Debug.Log("LocomotionState: Current State is Parent Class.");
    }

    public override void Move(Vector2 direction)
    {
        Locomotion.InputDirection = direction;
    }

    public override void Run()
    {
        Debug.Log("LocomotionState: Current State is Parent Class.");
    }
}