using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject target;

    public void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, 2f * Time.deltaTime);
    }
}
