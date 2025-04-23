using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] Rigidbody rigid;
    [SerializeField] private int hp;

    Vector3 dir;

    private void OnEnable()
    {
        hp = 3;
    }

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        float dirX = Input.GetAxis("Horizontal");
        float dirZ = Input.GetAxis("Vertical");

        dir = new Vector3(dirX, 0, dirZ).normalized;

        rigid.velocity = dir * moveSpeed;
    }

    public void TakeDamage()
    {
        hp--;
        if (hp <= 0)
        {
            GameManager.Instance.OnDied.Invoke();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            TakeDamage();
        }
    }
}
