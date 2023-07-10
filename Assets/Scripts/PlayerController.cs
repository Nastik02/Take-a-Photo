using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Health))]

public class PlayerController : FishController
{
    [SerializeField] private Joystick _joystick;
    [SerializeField] private float _interactRange = 2f;
    private LayerMask _interactMask;
    private SpriteRenderer _renderer;
    private Animator _animator;
    private Health _health;
    private IInteractable _currentInteractable;
    public UnityEvent<IInteractable> OnEnterIntractableZone;
    public UnityEvent OnExitIntractableZone;

    
    
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _rigidBody = GetComponent<Rigidbody2D>();
        _renderer = GetComponentInChildren<SpriteRenderer>();
        _health = GetComponent<Health>();
        _interactMask = LayerMask.GetMask("Interactive Objects");
}

    private void Update()
    {
        
        Vector2 direction = new Vector2();
        if (_health.IsAlive) 
        {
            if(Input.GetKeyDown(KeyCode.Return)) TryInteract();

            direction.x = Input.GetAxis("Horizontal");
            direction.y = Input.GetAxis("Vertical");

            if (_joystick && _joystick.Direction.sqrMagnitude > 0)
            {
                direction = _joystick.Direction;
            }
        }

        Movement(direction);

        _renderer.flipX = _isMoving ? false : !_lookRight;
        _renderer.flipY = direction.x < 0.0f;
        _animator.SetBool("IsMoving", _isMoving);
    }
    public void TryInteract()
    {
        if (_health.IsAlive && _currentInteractable != null && !_isMoving)
        {
            _currentInteractable.Interact();
        }
    }
    private void FixedUpdate()
    {
        CheckInteractableZones();
    }
    private void CheckInteractableZones()
    {
        Collider2D[] interactObjects = Physics2D.OverlapCircleAll(transform.position, _interactRange, _interactMask);
        IInteractable newInteractable = null;
        foreach (Collider2D interactObject in interactObjects)
        {
            if (interactObject.TryGetComponent(out IInteractable interactadle))
            {
                if (interactadle.IsAvailable) {
                    newInteractable = interactadle;
                    break;
                }
            }
        }
        if (_currentInteractable != newInteractable)
        {
            if (_currentInteractable != null)
            {
                OnExitIntractableZone?.Invoke();
            }
            if (newInteractable != null)
            {
                OnEnterIntractableZone?.Invoke(newInteractable);
            }
            _currentInteractable = newInteractable;
        }
    }

}
