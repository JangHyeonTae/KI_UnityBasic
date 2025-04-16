using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class ObjectPool : MonoBehaviour
{
    [SerializeField] private PooledObject pool;
    [SerializeField] private List<PooledObject> poolList;
    [SerializeField] private int poolSize;


    private void Awake()
    {
        poolList = new List<PooledObject>();

        MakePool();
    }

    private void MakePool()
    {
        for (int i = 0; i < poolSize; i++)
        {
            PooledObject instance = Instantiate(pool, transform);
            instance.gameObject.SetActive(false);
            poolList.Add(instance);
        }

    }

    public PooledObject CreateBullet(Vector3 position, Quaternion rotation)
    {
        if (poolList.Count == 0) return Instantiate(pool,position, rotation);

        PooledObject instance = poolList[poolList.Count - 1];
        poolList.RemoveAt(poolList.Count - 1);

        instance.objectPool = this;
        instance.transform.position = position;
        instance.transform.rotation = rotation;

        instance.gameObject.SetActive(true);
        return instance;
    }


    public void ReturnBullet(PooledObject instance)
    {
        instance.gameObject.SetActive(false);
        poolList.Add(instance);
    }

   
}
