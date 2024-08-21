using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    [SerializeField] private GameObject destination;
    [SerializeField] private float moveSpeed = 0.5f; // Scene upward speed
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, destination.transform.position, moveSpeed * Time.deltaTime);
    }
}
