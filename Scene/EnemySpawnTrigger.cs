using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnTrigger : MonoBehaviour
{
    [SerializeField] private GameObject[] spawners; // Enemy spawner 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Enable enemy spawners to spawn enemies
        {
            for (int i = 0; i < spawners.Length; i++)
            {
                spawners[i].SetActive(true);
            }
        }
    }
}
