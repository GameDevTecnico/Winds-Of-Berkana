using UnityEngine;

public interface ILocomotionState
{
    public void StartJump();
    public void StopJump();
    public void Move(Vector2 input);
    public void Run();
    public void Walk(bool walk);
    public void Fall();
    public void Ground();
    public void StartState();
    public void Tunnel();
    public void Break();
}