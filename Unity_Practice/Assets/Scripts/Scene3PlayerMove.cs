using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3PlayerMove : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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
