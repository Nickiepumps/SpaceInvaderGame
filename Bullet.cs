using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 5f;
    public Vector2 direction = Vector2.right; // Bullet direction
    private Vector2 velocity;

    private void Update()
    {
        velocity = direction * bulletSpeed;
    }
    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        pos += velocity * Time.fixedDeltaTime;
        transform.position = pos;
    }
}
