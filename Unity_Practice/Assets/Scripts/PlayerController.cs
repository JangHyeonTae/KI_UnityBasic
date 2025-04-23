using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

using static UnityEngine.GraphicsBuffer;

public class PlayerController : MonoBehaviour
{
    //[SerializeField] Shoot shoot;

    [SerializeField] float moveSpeed = 10;
    [SerializeField] float rotateSpeed = 45;

    //private Coroutine shootRoutine;
    //private Coroutine chargeRoutine;

    //[SerializeField] private int shootMode = 0;

    Vector3 dir;
    public JoyStick joystick;

    private void Start()
    {
        dir = Vector3.zero;
    }

    private void Update()
    {
        dir.x = joystick.Horizontal();
        dir.z = joystick.Vertical();

        Move();
        Rotation();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * dir.z * moveSpeed * Time.deltaTime);
    }

    private void Rotation()
    {
        transform.Rotate(Vector3.up * dir.x * rotateSpeed * Time.deltaTime);
    }

    #region Å°º¸µå
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Alpha1))
    //    {
    //        shootMode = 1;
    //        Debug.Log("ShootMode");
    //    }
    //    else if(Input.GetKeyDown(KeyCode.Alpha2))
    //    {
    //        shootMode = 2;
    //        Debug.Log("ChargeMode");
    //    }
    //
    //    if (shootMode == 1)
    //    {
    //        if (Input.GetKeyDown(KeyCode.Space) && shootRoutine == null)
    //        {
    //            shootRoutine = StartCoroutine(FireRoutine());
    //        }
    //        if (Input.GetKeyUp(KeyCode.Space))
    //        {
    //            if (shootRoutine != null)
    //            {
    //                StopCoroutine(shootRoutine);
    //                shootRoutine = null;
    //            }
    //        }
    //    }
    //    else if (shootMode == 2)
    //    {
    //        if (Input.GetKeyDown(KeyCode.Space) && chargeRoutine == null)
    //        {
    //            chargeRoutine = StartCoroutine(FireCharge());
    //        }
    //    }
    //
    //    Move();
    //    Rotation();
    //
    //    
    //}

    //private void Move()
    //{
    //    //float input = Input.GetAxis("Vertical");
    //    //transform.Translate(Vector3.forward * moveSpeed * input * Time.deltaTime);
    //
    //
    //}

    //private void Rotation()
    //{
    //    float input = Input.GetAxis("Horizontal");
    //    transform.Rotate(Vector3.up, rotateSpeed * input * Time.deltaTime);
    //}

    //IEnumerator FireCharge()
    //{
    //    float timer = 0;
    //
    //    while (true)
    //    {
    //        timer += Time.deltaTime * 10f;
    //        yield return null;
    //
    //        if (Input.GetKeyUp(KeyCode.Space))
    //        {
    //            break;
    //        }
    //    }
    //    float power = Mathf.Clamp(timer, 10f, 30f);
    //    shoot.Fire(power);
    //
    //    chargeRoutine = null;
    //}

    //IEnumerator FireRoutine()
    //{
    //    WaitForSeconds delay = new WaitForSeconds(1f);
    //    while (true)
    //    {
    //        shoot.Fire();
    //        yield return delay;
    //        
    //    }
    //}
    #endregion

}
