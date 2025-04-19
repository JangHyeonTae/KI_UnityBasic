using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageSpawn : MonoBehaviour
{
    //EnemyPool enemyPool;
    [SerializeField] Transform spawnPosition;
    public GameObject enemyPrefab;

    public float delay = 1f;
    public int enemyCount = 0;

    Coroutine enemyCor;

    public void StageEnemy()
    {
        if (spawnPosition == null) return;
        if (enemyCount <= 5 && enemyCor == null)
        {
            enemyCor = StartCoroutine(EnemyRoute());
        }
        
    }

    private Vector3 TransformPosition()
    {
        float xPos = Random.Range(-4, 4);
        float zPos = Random.Range(-4, 4);

        spawnPosition.transform.position = new Vector3(spawnPosition.transform.position.x + xPos,
            1.5f, spawnPosition.transform.position.z + zPos);

        return spawnPosition.transform.position;
    }

    private Quaternion TransformRotation()
    {
        float yRot = Random.Range(0, 360);

        Quaternion rot = Quaternion.Euler(0, yRot, 0);
        return rot;
    }

    private IEnumerator EnemyRoute()
    {
        while (true)
        {
            Instantiate(enemyPrefab, TransformPosition(), TransformRotation());
            enemyCount++;
            if (enemyCount >= 5 && enemyCor != null)
            {
                EnemyRouteStop();
            }
            yield return new WaitForSeconds(delay);

        }
    }

    private void EnemyRouteStop()
    {
        StopCoroutine(enemyCor);
        enemyCor = null;
    }
}
