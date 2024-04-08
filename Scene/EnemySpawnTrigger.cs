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
                if (spawners[i] != null) // Activate spawner when there is spawners GameObject in element
                {
                    spawners[i].SetActive(true);
                }
                else // Destroy Spawners Array when all elements are null
                {
                    Destroy(gameObject);
                }
                
            }
        }
    }
}
