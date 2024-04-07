using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private PlayerGun[] pGun;
    private float fireRates = 0.2f;
    private void Update()
    {
        fireRates -= Time.deltaTime;
        if (Input.GetMouseButton(0) && fireRates <= 0f)
        {
            foreach(PlayerGun gun in pGun)
            {
                // Shoot bullet when gun is active
                if(gun.isActiveAndEnabled)
                gun.Shoot();
                fireRates = 0.2f;
            }
        }
    }
}
