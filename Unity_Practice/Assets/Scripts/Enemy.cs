using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float targetSpeed;
    [SerializeField] Transform rayPosition;

    [SerializeField] float range;

    public GameObject target;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RayCollider();
        Debug.DrawLine(rayPosition.position, rayPosition.position + rayPosition.forward * range, Color.green);
        if (target != null)
        {
            Trace();
            Attack();
        }
    }

    private void Trace()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        transform.LookAt(target.transform.position);

    }

    private void RayCollider()
    {
        if (Physics.Raycast(transform.position, rayPosition.forward, out RaycastHit hit, range))
        {
            PlayerController player = hit.collider.gameObject.GetComponent<PlayerController>();
            if (player != null)
            {
                Debug.DrawLine(rayPosition.position, hit.point, Color.red);
                target = hit.collider.gameObject;
            }
            else
            {
                target = null;
            }


        }
        else
        {
            Debug.DrawLine(rayPosition.position, rayPosition.position + rayPosition.forward * 10f, Color.red);
            target = null;
        }
    }

    public void Attack()
    {
        if (Physics.Raycast(transform.position, rayPosition.forward, out RaycastHit hitInfo, 1))
        {
            PlayerController player = hitInfo.collider.gameObject.GetComponent<PlayerController>();
            if (player != null)
            {
                Destroy(target.gameObject);
            }
            else
            {
                target = null;
            }
        }
        else
        {
            target = null;
        }
    }
}
