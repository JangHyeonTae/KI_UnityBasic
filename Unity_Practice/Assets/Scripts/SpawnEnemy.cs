using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    EnemyPool enemyPool;
    [SerializeField] float spawnTime=5;
    float timer;

    private void Awake()
    {
        timer = spawnTime;
        enemyPool = FindObjectOfType<EnemyPool>();
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0 )
        {
            enemyPool.CreateEnemy(RandomPosition(), RandomRotation());
            timer = spawnTime;
        }
    }

    private Vector3 RandomPosition()
    {
        float xPos = Random.Range(-10, 10);
        float zPos = Random.Range(-10, 10);

        Vector3 pos = new Vector3(xPos, 1, zPos);

        return pos;
    }

    private Quaternion RandomRotation()
    {
        float yRot = Random.Range(0, 360);

        Quaternion rot = Quaternion.Euler(0, yRot, 0);
        return rot;
    }
}
