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


    private void Start()
    {
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot.Fire();
        }
        Move();
        MoveRotateion();
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }

    private void MoveRotateion()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
        }
    }


    

}
