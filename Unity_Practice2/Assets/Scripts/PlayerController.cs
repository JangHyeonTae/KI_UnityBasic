using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float upSpeed;
    [SerializeField] private float rotationSpeed;

    [SerializeField] RawImage[] cctv;

    [SerializeField] private int keyNum = -1;

    private Vector3 movement;
    Coroutine cctvPress;


    private void FixedUpdate()
    {
        MovePos();
        transform.Rotate(Vector3.up * movement.x * rotationSpeed * Time.deltaTime);
    }
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.z = Input.GetAxis("Vertical");
        CamCon();
    }

    private void MovePos()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.forward * movement.z * upSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.forward * movement.z * moveSpeed * Time.deltaTime);
        }
    }

    private void CamCon()
    {
        if (cctvPress == null)
        {
            
            if (Input.GetKey(KeyCode.Alpha1))
            {
                cctvPress = StartCoroutine(Press(1));
            }
            else if (Input.GetKey(KeyCode.Alpha2))
            {
                cctvPress = StartCoroutine(Press(2));
            }
        }
        
    }


    private IEnumerator Press(int index)
    {
        while (true)
        {
            yield return null;
            cctv[index-1].gameObject.SetActive(true);
            
            if (Input.GetKeyUp(KeyCode.Alpha1) || Input.GetKeyUp(KeyCode.Alpha2))
            {
                break;
            }
        }
        StartCoroutine(StopPress(index - 1));

    }

    private IEnumerator StopPress(int index)
    {
        cctv[index].gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        StopCoroutine(cctvPress);
        cctvPress = null;
        yield return null;
    }
}
