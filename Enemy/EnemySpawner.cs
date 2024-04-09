using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab; // Enemy Prefab
    [SerializeField] private int enemyAmount = 5; // Max Amount of enemy to spawn
    [SerializeField] private float spawnRate = 0.5f; // Time between each spawn
    private float timer = 0; // Start timer
    private int enemyCount = 0; // enemyCounter

    [SerializeField] private bool StraightDownMovement, WaveMovement = false; // Boolean for enemy movement types
                                                    // TO DO: use them when finished making different movement pattern
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0) // Spawn an enemy when timer reached 0
        {
            if (enemyCount < enemyAmount) // spawn when enemyCount is lesser than enemyAmount 
            {
                SpawnEnemy();
            }
            else // Destroy spawner GameObject when reached total amount of enemy to spawn
            {
                Destroy(gameObject);
            }
        }
    }
    public void SpawnEnemy()
    {
        GameObject enemyClone = Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        
        if (StraightDownMovement == true)
        {
            enemyClone.GetComponent<EnemyMovement>().StraightDownMovement = true;
        }
        if (WaveMovement == true)
        {
            enemyClone.gameObject.GetComponent<EnemyMovement>().WaveMovement = true;
        }
        timer = spawnRate;
        enemyCount++;

    }
}
