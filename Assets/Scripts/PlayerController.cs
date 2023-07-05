using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private Joystick _joystick;

    private Vector2 _direction;
    private Rigidbody2D _rigidBody;
    private SpriteRenderer _renderer;
    private Animator _animator;
    private bool _lookRight = true;
    private bool _isMoving;


    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _rigidBody = GetComponent<Rigidbody2D>();
        _renderer = GetComponentInChildren<SpriteRenderer>();

    }

    private void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.y = Input.GetAxis("Vertical");

        if (_joystick && _joystick.Direction.sqrMagnitude > 0)
        {
            _direction = _joystick.Direction;
        }

        Movement();

        _renderer.flipX = _isMoving ? false : !_lookRight;
        _renderer.flipY = _direction.x < 0.0f;
        _animator.SetBool("IsMoving", _isMoving);
    }
    private void Movement()
    {
        _rigidBody.velocity = _direction * _speed;
        _isMoving = _direction.sqrMagnitude > 0;
        transform.rotation = Quaternion.identity;
        if (_isMoving)
        {
            var angle = Vector2.SignedAngle(Vector2.right, _direction);
            var targetRotation = new Vector3(0, 0, angle);
            var lookTo = Quaternion.Euler(targetRotation);
            transform.rotation = lookTo;
            _lookRight = _direction.x > 0.0f;
        }
    }
}
