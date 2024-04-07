using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private float moveSpeed = 2f; // Camera upward speed
    private void FixedUpdate()
    {
        Vector3 direction = Vector3.up * moveSpeed * Time.fixedDeltaTime;
        transform.position = transform.position + direction;
    }
}
