using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f; // Scene upward speed
    private void FixedUpdate()
    {
        Vector3 direction = Vector3.down * moveSpeed * Time.fixedDeltaTime;
        transform.position = transform.position + direction;
    }
}
