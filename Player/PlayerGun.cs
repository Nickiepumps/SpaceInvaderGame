using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    public PlayerBullets bullet;
    public Vector2 gunDirection;
    private void Start()
    {
        gunDirection = transform.localRotation * Vector2.up;
    }
    public void Shoot()
    {
        //GameObject bGo = Instantiate(bullet.gameObject, transform.position, transform.rotation);
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
