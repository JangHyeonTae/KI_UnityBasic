using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IDamagableAdapter : MonoBehaviour, IDamagable
{
    public UnityEvent<GameObject,int> OnDamaged;

    public void TakeDamage(GameObject prefab, int damage)
    {
        OnDamaged?.Invoke(prefab, damage);
    }
}
