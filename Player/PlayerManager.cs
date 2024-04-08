using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int playerMaxHP = 3; // Player MaxHP amount
    public int playerCurrentHP; // Player current HP
    private void Start()
    {
        playerCurrentHP = playerMaxHP;
    }
    public void Update()
    {       
        if(playerCurrentHP <= 0) // Destroy Player Ship when HP reached 0
        {            
            Destroy(gameObject);
        }
        if(playerCurrentHP > playerMaxHP) // If PlayerHP is greater than MaxHp when Healed, Restore current HP back to MaxHP
        {
            playerCurrentHP = playerMaxHP;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy")) // Reduce Player Current HP by 1 when hit an enemy
        {
            playerCurrentHP--;
        }
    }
}
