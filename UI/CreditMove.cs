using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditMove : MonoBehaviour
{
    [SerializeField] private GameObject destination; // credit GameObject Destination
    [SerializeField] private float speed = 5f; // Credit Move Speed
    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, destination.transform.position, speed * Time.deltaTime);        
    }
}
