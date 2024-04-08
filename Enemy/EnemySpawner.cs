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
    private void Start()
    {
        if(StraightDownMovement == true)
        {
            enemyPrefab.GetComponent<EnemyMovement>().StraightDownMovement = true;
        }
        if(WaveMovement == true)
        {
            enemyPrefab.GetComponent<EnemyMovement>().WaveMovement = true;
        }
    }
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
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);
        timer = spawnRate;
        enemyCount++;

    }
}
