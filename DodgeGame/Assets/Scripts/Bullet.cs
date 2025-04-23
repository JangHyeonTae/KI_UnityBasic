using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;
    [SerializeField] float bulletSpeed;
    public List<GameObject> bulletPool;

    void OnEnable()
    {
        rigid.AddForce(transform.forward * bulletSpeed,ForceMode.Impulse);
        StartCoroutine(ReturnBullet(3f));
    }

    private void Update()
    {
        if(GameManager.Instance.isGameOver)
        {
            StartCoroutine(ReturnBullet(0));
        }
    }

    private IEnumerator ReturnBullet(float returnTime)
    {
        yield return new WaitForSeconds(returnTime);
        rigid.velocity = Vector3.zero;
        gameObject.SetActive(false);
        bulletPool.Add(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(ReturnBullet(0));
        }
    }
}
