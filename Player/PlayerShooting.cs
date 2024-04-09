using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private PlayerGun[] pGun;
    private float fireRates = 0.2f;
    //public int maxGunLevel = 5;
    public int currentGunLevel;
    private void Start()
    {
        currentGunLevel = 1;
    }
    private void Update()
    {
        fireRates -= Time.deltaTime;
        if (Input.GetMouseButton(0) && fireRates <= 0f)
        {
            for(int i = 0; i < currentGunLevel; i++)
            {                
                pGun[i].Shoot();
                fireRates = 0.2f;
            }
        }
    }
}
