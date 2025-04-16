using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class PooledObject : MonoBehaviour
{
    public ObjectPool objectPool;
    public int returnTime;
    private float timer;
    

    public int speed = 10;

    private void Awake()
    {
    }
    private void OnEnable()
    {
        timer = returnTime;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            ReturnPool();
        }
    }

    public void ReturnPool()
    {
        if (objectPool == null)
        {
            Destroy(gameObject);
        }
        else
        {
            objectPool.ReturnBullet(this);
        }
    }


    
}
