using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullets : MonoBehaviour
{
    [SerializeField] private GameObject bullet; // Bullet prefab
    private float speed = 10f; // Bullet speed
    public Vector2 bulletDirection = Vector2.up; // Bullet direction
    private void Update()
    {
        Vector2 bPos = transform.position;
        bPos += bulletDirection * speed * Time.deltaTime;
        transform.position = bPos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}