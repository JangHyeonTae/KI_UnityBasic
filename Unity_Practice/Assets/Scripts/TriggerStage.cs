using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerStage : MonoBehaviour
{
    public UnityEvent OnTrig;
    [SerializeField] private GameObject doorPrefab;
    void Awake()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(doorPrefab);
            OnTrig.Invoke();
            Destroy(gameObject);
        }
    }

    
}
