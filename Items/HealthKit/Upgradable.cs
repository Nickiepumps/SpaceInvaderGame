using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgradable : MonoBehaviour
{
    [SerializeField] private PlayerShooting playerGunUpgrade;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ship"))
        {
            if (playerGunUpgrade.currentGunLevel <= 5)
            {
                playerGunUpgrade.currentGunLevel++;
                Destroy(gameObject);
            }
        }
    }
}
