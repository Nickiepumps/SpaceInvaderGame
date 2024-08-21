using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgradable : MonoBehaviour
{
    [SerializeField] private PlayerShooting playerGunUpgrade;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ship")) // If Item hit player, Upgrade gun level by 1, if gun level reached level 5, dont destroy it
        {
            if (playerGunUpgrade.currentGunLevel < 5)
            {
                playerGunUpgrade.currentFireRates = playerGunUpgrade.currentFireRates += -0.05f; // Increase Firerate by 0.05
                playerGunUpgrade.currentGunLevel++;                
                Destroy(gameObject);
            }
        }
    }
}
