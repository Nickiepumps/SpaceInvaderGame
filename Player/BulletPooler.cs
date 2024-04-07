using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPooler : MonoBehaviour
{
    public static BulletPooler instance;
    public List<GameObject> bulletPool;
    public GameObject bulletToPool;
    public int size;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
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
    public GameObject SpawnBulletFromPool(Quaternion rotation)
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
