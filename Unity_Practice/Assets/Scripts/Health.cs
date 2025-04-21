using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour,IDamagable
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

    public void TakeDamage(GameObject prefab, int damage)
    {
        curHp -= damage;
        if (curHp <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        //enemyPool.ReturnEnemy(enemy);
        GameManager.Instance.score += 1;
        Destroy(gameObject);
    }
}
