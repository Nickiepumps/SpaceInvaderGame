using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb; // Player RB
    private float moveX, moveY; // X and Y direction
    [SerializeField] private float speed = 5f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        moveX = Input.GetAxis("Horizontal") * speed;
        moveY = Input.GetAxis("Vertical") * speed;
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveX, moveY);
    }
}
