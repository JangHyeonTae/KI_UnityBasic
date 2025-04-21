using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float dirX, dirZ;
    [SerializeField] float moveSpeed = 10f;
    Vector3 dir = Vector3.zero;
    [SerializeField] float range = 3f;
    void Update()
    {
        Move();

        if (Input.GetKeyDown(KeyCode.G))
        {
            RayNpc();
        }
    }
    public void RayNpc()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, range))
        {
            IInteractive interact = hit.collider.gameObject.GetComponent<IInteractive>();
            if (interact != null)
            {
                UseItem(interact);
            }
        }
    }

    public void UseItem(IInteractive interact)
    {
        interact.Interactive(gameObject);
    }

    public void Move()
    {
        dirX = Input.GetAxis("Horizontal");
        dirZ = Input.GetAxis("Vertical");

        dir = new Vector3(dirX,0,dirZ);

        gameObject.transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
