using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform rayPosition;

    [SerializeField] float range;
    public GameObject target;

    void Update()
    {
        //RayCollider();

        if(target != null)
        {
            Trace();
        }
    }

    private void Trace()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        transform.LookAt(target.transform.position);
    }

    public void SetTarget(GameObject _target)
    {
        if (_target != null)
        {
            _target = GameObject.FindGameObjectWithTag("Player");
            target = _target;
        }
        
    }


    //private void RayCollider()
    //{
    //    if (Physics.Raycast(transform.position, rayPosition.forward, out RaycastHit hit, range))
    //    {
    //        //PlayerController player = hit.collider.gameObject.GetComponent<PlayerController>();
    //        //if (player != null)
    //        if(hit.collider.CompareTag("Player"))
    //        {
    //            Debug.DrawLine(rayPosition.position, hit.point, Color.red);
    //            target = hit.collider.gameObject;
    //        }
    //        else
    //        {
    //            target = null;
    //        }
    //    }
    //    else
    //    {
    //        Debug.DrawLine(rayPosition.position, rayPosition.position + rayPosition.forward * 10f, Color.green);
    //        target = null;
    //    }
    //}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }

}
