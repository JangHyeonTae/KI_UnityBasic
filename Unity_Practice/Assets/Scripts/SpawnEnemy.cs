using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    EnemyPool enemyPool;
    [SerializeField] Transform spawnPosition;
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
        if (timer < 0)
        {
            enemyPool.CreateEnemy(TransformPosition(), TransformRotation());
            timer = spawnTime;
        }
        
    }

    private Vector3 TransformPosition()
    {
        float xPos = Random.Range(-5, 5);
        float zPos = Random.Range(-5, 5);

        spawnPosition.transform.position = new Vector3(spawnPosition.transform.position.x +xPos, 
            1, spawnPosition.transform.position.z + zPos);

        return spawnPosition.transform.position;
    }

    private Quaternion TransformRotation()
    {
        float yRot = Random.Range(0, 360);

        Quaternion rot = Quaternion.Euler(0, yRot, 0);
        return rot;
    }
}
