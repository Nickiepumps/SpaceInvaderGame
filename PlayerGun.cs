using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public Vector2 gunDirection; // Direction gun facing
    private void Start()
    {
        gunDirection = transform.localRotation * Vector2.up; // Store rotation data into the gunDirection
    }
    public void Shoot()
    {
        GameObject bullet = BulletPooler.instance.SpawnBulletFromPool(transform.rotation);
        if(bullet != null)
        {
            PlayerBullets bulletShoot = bullet.GetComponent<PlayerBullets>();
            bullet.transform.position = transform.position; // Bullet spawn position
            bulletShoot.bulletDirection = gunDirection; // Bullet shooting direction 
            bullet.SetActive(true);        
        }
    }
}
