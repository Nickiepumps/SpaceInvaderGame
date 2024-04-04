using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private Vector2 direction; // Gun Direction
    public Bullet bullet;
    public void ShootBullet()
    {
        direction = (transform.localRotation * Vector2.right).normalized;
        Debug.Log("Shoot");
        GameObject bulletGo = Instantiate(bullet.gameObject, transform.position, transform.rotation);
        Bullet goBullet = bulletGo.GetComponent<Bullet>();
        goBullet.direction = direction;
    }
}
