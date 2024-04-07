using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1f; // Enemy movement speed
    [SerializeField] private Vector2 direction = Vector2.down; // Enemy move downward by default
    private Rigidbody2D enemyRb; // enemy RB
    private void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        DownwardMovement();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish")) // To do : change Tag later
        {
            Destroy(gameObject);
        }
    }
    private void DownwardMovement()
    {
        enemyRb.velocity = direction * speed;
    }
}
