using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Switch : MonoBehaviour
{
    public GameObject door;
    public event Action OnOpen;

    [SerializeField] StageSpawn stageSpawn;
    public void Awake()
    {
        stageSpawn = FindObjectOfType<StageSpawn>();
    }

    private void OnEnable()
    {
        OnOpen += stageSpawn.StageEnemy;
    }

    private void OnDisable()
    {
        OnOpen -= stageSpawn.StageEnemy;
    }
    public void SwitchAction()
    {
        if (door.activeSelf)
        {
            Open();
            OnOpen?.Invoke();
        }
        else
        {
            Close();
        }
    }

    public void Open()
    {
        door.SetActive(false);
    }

    public void Close()
    {
        door.SetActive(true);
    }
}
