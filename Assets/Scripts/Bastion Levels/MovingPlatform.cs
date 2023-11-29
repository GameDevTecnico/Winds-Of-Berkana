using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 5f;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _distance = 10f;
    [SerializeField] private bool _rotate = false;
    [SerializeField] private bool _move = false;
    private Vector3 _direction = Vector3.forward;
    private Vector3 _initialPosition;
    public Vector3 Velocity = Vector3.zero;
    private Vector3 _lastPosition = Vector3.zero;

    private void Update()
    {
        transform.Translate(Time.deltaTime * _speed * _direction);
        if (Vector3.Distance(_initialPosition, transform.position) > _distance)
        {
            _direction *= -1;
        }
        Velocity = (transform.position - _lastPosition) / Time.deltaTime;
        _lastPosition = transform.position;
    }

    private void Start()
    {
        _direction = transform.forward;
        _initialPosition = transform.position;
        _initialPosition = transform.position;
    }
}