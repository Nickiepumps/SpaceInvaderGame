using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthKit : MonoBehaviour
{
    public PlayerManager player;
    [SerializeField] public int hpAmount = 3; // HP amount to restore player HP
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ship"))
        {            
            player.playerCurrentHP += hpAmount;            
            Destroy(gameObject);
        }
    }
}
