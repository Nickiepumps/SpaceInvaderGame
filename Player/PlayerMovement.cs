using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb; // Player RB
    private float moveX, moveY; // X and Y direction
    [SerializeField] private float speed = 5f; // Movement speed
    private PlayerManager playerManager; // Player HP Data
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); 
        playerManager = GetComponentInChildren<PlayerManager>();
    }
    private void Update()
    {
        if (playerManager.isDead != true) // Move Player when hp is not 0
        {
            moveX = Input.GetAxis("Horizontal") * speed;
            moveY = Input.GetAxis("Vertical") * speed;
        }
        else
        {
            moveX = 0;
            moveY = 0;
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveX, moveY);
    }
}
