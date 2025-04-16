using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rigid;
    public float moveSpeed = 5;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigid.AddForce(Vector3.forward * moveSpeed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rigid.AddForce(Vector3.back * moveSpeed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rigid.AddForce(Vector3.left * moveSpeed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigid.AddForce(Vector3.right * moveSpeed, ForceMode.Force);
        }
    }
}
