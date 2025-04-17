using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

using static UnityEngine.GraphicsBuffer;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Shoot shoot;

    [SerializeField] float moveSpeed = 10;
    [SerializeField] float rotateSpeed = 45;


    private void Awake()
    {

    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot.Fire();
        }
        Move();
        Rotation();
    }

    private void Move()
    {
        float input = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * moveSpeed * input * Time.deltaTime);
    }

    private void Rotation()
    {
        float input = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, rotateSpeed * input * Time.deltaTime);
    }

}
