using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPooler : MonoBehaviour
{
    public static BulletPooler instance; // Use for calling function in other scripts
    public List<GameObject> bulletPool; // Bullet Pool
    public GameObject bulletToPool; // Bullet GameObject
    public int size; // Pool size
    private void Awake() // Singleton
    {
        instance = this;
    }
    private void Start() // Instantiate object,disable it and add Bullet GameObject in the list
    {
        bulletPool = new List<GameObject>();
        GameObject bullet;
        for(int i = 0; i < size; i++)
        {
            bullet = Instantiate(bulletToPool);
            bullet.SetActive(false);
            bulletPool.Add(bullet);
        }

    }
    public GameObject SpawnBulletFromPool(Quaternion rotation) // Make bullet's rotation accordingly to the gun's rotation
    {
        for(int i = 0; i < size; i++)
        {
            if (!bulletPool[i].activeInHierarchy)
            {
                bulletPool[i].transform.rotation = rotation;
                return bulletPool[i];
            }
        }
        return null;
    }

}
