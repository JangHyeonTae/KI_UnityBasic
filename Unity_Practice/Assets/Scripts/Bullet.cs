using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;
    public GameObject particle;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (rigid.velocity.magnitude > 2)
        {
            transform.forward = rigid.velocity;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Bullet"))
        {
            return;
        }
        else
        {
            Health health = collision.gameObject.GetComponent<Health>();
            
            if (health != null)
            {
                Debug.Log("Ãæµ¹");
                health.TakeDamage(3);
            }
            
            
            Destroy(this.gameObject);
            Instantiate(particle, transform.position, Quaternion.identity);
        }
    }

}
