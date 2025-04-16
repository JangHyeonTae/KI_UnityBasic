using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Rotation : MonoBehaviour
{
    public GameObject m_Center;
    public GameObject h_Center;

    public int h_Time = 0;
    public int m_Time = 0;

    void Update()
    {
        m_Center.transform.rotation = Quaternion.Euler(0, m_Time * 6, 0);
        h_Center.transform.rotation = Quaternion.Euler(0, h_Time * 30, 0);
    }

}

