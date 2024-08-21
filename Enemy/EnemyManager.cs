using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private AudioSource explosionEnemy; // Ship Explosion Player
    [SerializeField] private GameObject explosion, fireEngine; // Explosion and Fire Sprite Anim
    [SerializeField] private GameObject enemyParents; // Enemy parent
    public int enemyMaxHP = 3; // Enemy max HP amount
    public int enemyCurrentHP; // Enemy current HP Amount
    private void Start()
    {
        enemyCurrentHP = enemyMaxHP;
    }
    public void Update()
    {        
        if(enemyCurrentHP <= 0) // Destroy enemy GameObject when current enemy hp <= 0
        {
            fireEngine.SetActive(false);
            explosion.SetActive(true); // Enabled Explosion Sprite Anim
            explosionEnemy.Play(); // play Explosion sound before destroying gameobject
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ship")) // Destroy enemy object when enter PlayerShip trigger
        {
            fireEngine.SetActive(false);
            explosion.SetActive(true); // Enabled Explosion Sprite Anim
            explosionEnemy.Play(); // play Explosion sound before destroying gameobject
            Destroy(gameObject);
        }
        if (collision.CompareTag("EnemyClear")) // Destroy enemy object when enter Enemyclear
        {
            Destroy(enemyParents);
        }
        if (collision.CompareTag("Bullet")) // Reduce enemy Hp by 1 when hit the bullet
        {
            enemyCurrentHP--;            
        }
    }
}
