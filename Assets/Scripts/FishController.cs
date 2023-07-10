using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class FishController : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    protected Rigidbody2D _rigidBody;
    protected bool _isMoving;
    protected bool _lookRight = true;

    protected void Movement(Vector2 direction)
    {
        _rigidBody.velocity = direction * _speed;
        _isMoving = direction.sqrMagnitude > 0;
        transform.rotation = Quaternion.identity;
        if (_isMoving)
        {
            var angle = Vector2.SignedAngle(Vector2.right, direction);
            var targetRotation = new Vector3(0, 0, angle);
            var lookTo = Quaternion.Euler(targetRotation);
            transform.rotation = lookTo;
            _lookRight = direction.x > 0.0f;
        }
    }
}
