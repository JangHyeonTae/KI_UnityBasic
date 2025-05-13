using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;
    [SerializeField] Anim_PlayerModel model;
    [SerializeField] Animator animator;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Fire();
        }
        Move();
    }

    private void Move()
    {
        float dirX = Input.GetAxis("Horizontal");
        float dirZ = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(dirX, 0, dirZ);
        if (dir.sqrMagnitude > 1)
        {
            dir = dir.normalized;
        }

        rigid.velocity = Vector3.MoveTowards(rigid.velocity, dir * model.MoveSpeed, model.Acceleration * Time.deltaTime);
        if (dir != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(dir);
        }

        animator.SetFloat("MoveSpeed", rigid.velocity.magnitude);
    }

    private void Fire()
    {
        animator.SetTrigger("Fire");
        //animator.SetLayerWeight(1, 0);
    }
}
