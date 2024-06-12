using System.Collections;
using UnityEngine;

public class FallingState : MonoBehaviour, ILocomotionState
{
    [SerializeField] private float _gravity = 3f;
    [SerializeField] private float _maxFallSpeed = 10f;
    [SerializeField] private float _acceleration = 5f;
    [SerializeField] private float _maxSpeed = 10f;
    [SerializeField] private float _deceleration = 5f;
    [SerializeField] private float _rotationSpeed = 10f;
    [SerializeField] private float _animationDelay = 0.1f;
    [SerializeField] private float _glideDelay = 0.3f;
    private bool _walk = false;
    private CharacterLocomotion _characterLocomotion;
    private bool _startAnimation = true;
    private bool _isPressingJump = false;

    public void StartState()
    {
        _startAnimation = true;
        StartCoroutine(StartFall());
    }

    private IEnumerator StartFall()
    {
        float startTime = Time.time;
        while (Time.time - startTime < _animationDelay)
        {
            yield return new WaitForEndOfFrame();
        }
        if (_startAnimation)
        {
            _characterLocomotion.ChangeAnimationState(CharacterAnimation.AnimationState.falling);
        }
    }

    public void StartJump()
    {
        _isPressingJump = true;
        StartCoroutine(StartGlide());
    }

    private IEnumerator StartGlide()
    {
        yield return new WaitForSeconds(_glideDelay);
        if (_isPressingJump)
        {
            _characterLocomotion.ChangeState<GlidingState>();
        }
    }

    public void StopJump()
    {
        _isPressingJump = false;
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
        _walk = walk;
    }

    public void Fall()
    {
        _characterLocomotion.ChangeFallVelocity(_gravity, _maxFallSpeed, _gravity);
    }

    public void Ground()
    {
        _startAnimation = false;
        _isPressingJump = false;
        _characterLocomotion.ChangeState<RunningState>();
    }

    public void Tunnel() { }

    private void Awake()
    {
        _characterLocomotion = GetComponent<CharacterLocomotion>();
    }

    public void Break()
    {
    }
}