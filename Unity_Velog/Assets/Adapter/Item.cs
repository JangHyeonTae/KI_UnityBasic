using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Item : MonoBehaviour, IInteractive
{
    string item;
    public Item()
    {
        item = "Potion";
    }
    public void Interactive(GameObject prefab)
    {
        Debug.Log($"{gameObject.name}을 사용합니다");
        Destroy( gameObject );
        Debug.Log($"{gameObject.name}이 사라졌습니다");
    }

}
