using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] float rotateSpeed;
    void Update()
    {
        Rotation();
    }
    private void Rotation()
    {
        float dirH = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * dirH * rotateSpeed * Time.deltaTime);
    }
}
