using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPool : MonoBehaviour
{
    [SerializeField] int size = 5;
    public List<Enemy> pool;
    public Enemy enemyPrefab;
    private void Awake()
    {
        pool = new List<Enemy>();
        for (int i = 0; i < size; i++)
        {
            Enemy instance = Instantiate(enemyPrefab, transform);
            instance.gameObject.SetActive(false);
            pool.Add(instance);
        }
    }

    public Enemy CreateEnemy(Vector3 position, Quaternion rotation)
    {
        if (pool.Count <= 0) return null;
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
