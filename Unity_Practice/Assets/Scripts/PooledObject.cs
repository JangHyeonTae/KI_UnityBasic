using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class PooledObject : MonoBehaviour
{
    public ObjectPool objectPool;
    public int returnTime;
    private float timer;


    private void Awake()
    {
        objectPool = FindObjectOfType<ObjectPool>();
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
