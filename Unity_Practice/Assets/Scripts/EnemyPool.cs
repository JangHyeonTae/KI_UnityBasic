using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    [SerializeField] Enemy enemyPrefab;
    List<Enemy> pool;
    public Enemy[] Pool { get; private set; }
    [SerializeField] int size = 5;
    public int enemyNum = 0;
    private void Awake()
    {
        AddPool();
    }

    private void AddPool()
    {
        pool = new List<Enemy>();
        for(int i=0; i<size; i++)
        {
            Enemy instance = Instantiate(enemyPrefab, transform);
            instance.gameObject.SetActive(false);
            pool.Add(instance);
        }
    }


    public Enemy CreateEnemy(Vector3 position, Quaternion rotation)
    {
        if (pool.Count <= 0) return null;
        //else if (enemyNum > 5) return null;
        //
        //if (enemyNum >= pool.Length-1)
        //{
        //    while (!pool[enemyNum].gameObject.activeInHierarchy)
        //    {
        //        enemyNum--;
        //    }
        //}
        //else if(pool[enemyNum].gameObject.activeInHierarchy && enemyNum <= pool.Length-1)
        //{ enemyNum++; }
        //Enemy instance = pool[enemyNum];

        Enemy instance = pool[pool.Count-1];
        pool.RemoveAt(pool.Count - 1);

        instance.transform.position = position;
        instance.transform.rotation = rotation;
        instance.gameObject.SetActive(true);
        return instance;

    }

    public void ReturnEnemy(Enemy enemy)
    {
        enemy.gameObject.SetActive(false);
        pool.Add(enemy);
    }

    
}
