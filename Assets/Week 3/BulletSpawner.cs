using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject prefab;
    public Bullet bullet;

    void Start()
    {
        Spawn();
    }

    void Update()
    {
        if(bullet == null)
        {
            Spawn();
        }

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Spawn()
    {
       // GameObject spawnedBullet = ;
        bullet = Instantiate(prefab).GetComponent<Bullet>();
    }

    void Fire()
    {
        bullet.hasBeenFired = true;
        bullet = null;
    }
}
