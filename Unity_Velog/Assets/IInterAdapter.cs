using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IInterAdapter : MonoBehaviour, IInteractive
{
    public UnityEvent<GameObject> OnInter;
    public void Interactive(GameObject prefab)
    {
        OnInter?.Invoke(prefab);
    }
}
