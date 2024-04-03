using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Gun[] guns;
    private float shootCoolDown = 0f; // Time between firing

    private void Update()
    {
        shootCoolDown -= Time.deltaTime;
        if(Input.GetMouseButton(0) && shootCoolDown <= 0)
        {
            foreach(Gun gun in guns)
            {
                gun.ShootBullet();
            }            
            shootCoolDown = 0.15f;
        }
    }
}
