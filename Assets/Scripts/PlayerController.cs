using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Vector2 direction;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        sprite.flipX = Input.GetAxis("Horizontal") < 0.0f;
    }
    void FixedUpdate()
    {
        Movement();
        
    }
    private void Movement()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + direction * speed * Time.deltaTime);
    }


}
