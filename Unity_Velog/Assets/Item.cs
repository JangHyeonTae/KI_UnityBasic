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
        Debug.Log($"{gameObject.name}�� ����մϴ�");
        Destroy( gameObject );
        Debug.Log($"{gameObject.name}�� ��������ϴ�");
    }

}
