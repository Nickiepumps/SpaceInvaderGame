using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private AudioSource shootSound; // Shoot Sound
    [SerializeField] private PlayerGun[] pGun; // Player Guns
    private float startFireRates = 0.3f; // Start Firerate
    public float currentFireRates; // Current Firerate
    public int currentGunLevel; // Current Gun Level
    private void Start()
    {
        currentGunLevel = 1; // gun level start at level 1
        currentFireRates = startFireRates;        
    }
    private void Update()
    {
        startFireRates -= Time.deltaTime;
        if (Input.GetMouseButton(0) && startFireRates <= 0f) // If clicked Left Mouse, Player shooting sound and shoot bullet
        {
            shootSound.Play();
            for (int i = 0; i < currentGunLevel; i++)
            {                
                pGun[i].Shoot();
                startFireRates = currentFireRates;
            }
        }
    }
}
