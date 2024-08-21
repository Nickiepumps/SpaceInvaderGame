using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 1f; // Enemy movement speed
    private Vector2 direction = Vector2.down; // Enemy movement direction
    public bool StraightDownMovement, WaveMovement = false; // Boolean for enemy movement types
    public Rigidbody2D enemyRb; // enemy RB

    // Sin Wave Movement Variables
    private float sinOffsetX,sinOffsetY;
    [SerializeField] private float amplitude = 1f;
    [SerializeField] private float frequency = 1f;
    private void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        sinOffsetX = transform.position.x;
        sinOffsetY = transform.position.y;
    }
    private void FixedUpdate()
    {
        if (StraightDownMovement == true)
        {
            DownwardMovement();
        }
        if (WaveMovement == true)
        {
            SineMovement();
        }           
    }   
    public void DownwardMovement() // Straight down Movement
    {
        enemyRb.velocity = direction * speed;
    }
    public void SineMovement() // Sine Pattern Movement
    {
        enemyRb.velocity = direction * speed;
        Vector2 pos = transform.position;
        float sin = amplitude * (Mathf.Sin(frequency * pos.y)); // Sine Wavein x direction with amplitude and frequency
        pos.x = sin + sinOffsetX; // Phase shift
        transform.position = pos;
    }
}
