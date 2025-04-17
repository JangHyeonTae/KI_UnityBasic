using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHp = 10;
    EnemyPool enemyPool;
    Enemy enemy;
    public int curHp;


    void Awake()
    {
        enemyPool = FindObjectOfType<EnemyPool>();
        enemy = GetComponent<Enemy>();
    }

    private void OnEnable()
    {
        curHp = maxHp;
    }

    public void TakeDamage(int damage)
    {
        curHp -= damage;
        if (curHp <= 0)
        {
            enemyPool.ReturnEnemy(enemy);
        }
    }
}
