using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GhostMove : MonoBehaviour
{
    [Header("Controller")]
    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private float range = 2f;
    public float plusX = 90f;
    public float plusZ = 3f;
    public float minusX = -60f;
    Vector3 movement = Vector3.zero;

    public int rand = -1;

    [Header("Laycast")]
    Ray ray;
    RaycastHit hit;
    

    [Header("Layer")]
    [SerializeField] private LayerMask moveOb;
    int wallNum;
    void Start()
    {
        wallNum = 1 << 3;
        StartCoroutine(GhostChangePos());
    }

    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit, range, moveOb))
        {
            if (moveOb == wallNum)
            {
                transform.eulerAngles += new Vector3(0, 180, 0);
            }
        }
        transform.Translate(Vector3.forward * plusZ * Time.deltaTime);
    }

    private IEnumerator GhostChangePos()
    {
        PlayerController player = FindObjectOfType<PlayerController>();
        while (player != null)
        {

            rand = Random.Range(0, 2);
            yield return new WaitForSeconds(1f);
            if (rand == 0)
            {
                gameObject.transform.eulerAngles += Vector3.up * plusX;
            }
            else if (rand == 1)
            {
                gameObject.transform.eulerAngles += Vector3.up * minusX;
            }
            
        }

        yield return null;
    }

    private void OnTriggerEnter(Collider other)
    {
        
        //int playerLayerNum = 1 << other.gameObject.layer;

        if (other.gameObject.layer == 8)
        {
            Debug.Log("½ÇÆÐ");
            Destroy(other.gameObject);
        }
        
    }

}
