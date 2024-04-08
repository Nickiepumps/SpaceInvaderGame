using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public int enemyMaxHP = 3; // Enemy max HP amount
    private int enemyCurrentHP; // Enemy current HP Amount
    private void Start()
    {
        enemyCurrentHP = enemyMaxHP;
    }
    public void Update()
    {        
        if(enemyCurrentHP <= 0) // Destroy enemy GameObject when current enemy hp <= 0
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemyClear") || collision.CompareTag("Ship")) // Destroy enemy object when enter Enemyclear and PlayerShip trigger
        {
            Destroy(gameObject);
        }
        if (collision.CompareTag("Bullet")) // Reduce enemy Hp by 1 when hit the bullet
        {
            enemyCurrentHP--;            
        }
    }
}
