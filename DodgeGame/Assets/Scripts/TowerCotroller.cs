using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCotroller : MonoBehaviour
{
    [SerializeField] private float rotateSpeed;
    [SerializeField] private Transform target;
    [SerializeField] LayerMask layerMask;
    [SerializeField] private float range; 
    [SerializeField] private int poolSize;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform muzzlePosition;
    [SerializeField] float timer;

    List<GameObject> pool;
    public Coroutine fireCor;
    private YieldInstruction delay;


    private void Awake()
    {
        
    }

    void Start()
    {
        delay = new WaitForSeconds(timer);
        pool = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab);
            bullet.GetComponent<Bullet>().bulletPool = pool;
            pool.Add(bullet);
            bullet.SetActive(false);
        }

        if (fireCor == null)
        {
            fireCor = StartCoroutine(Fire());
        }
    }

    void Update()
    {
        if (Physics.OverlapSphere(transform.position, range, layerMask).Length > 0)
        {
            TargetRotate();
        }
        else
        {
            TowerRotate();
        }
    }


    public IEnumerator Fire()
    {
        if (pool.Count <= 0) yield return null;

        while (true)
        {
            //인스턴스로 생성
            CreateBullet();
            yield return delay;
        }
    }

    private void CreateBullet()
    {
        GameObject bullet = pool[pool.Count - 1];
        pool.RemoveAt(pool.Count - 1);

        bullet.transform.position = muzzlePosition.position;
        bullet.transform.forward = transform.forward;
        bullet.SetActive(true);
    }

    private void TargetRotate()
    {
        Vector3 targetPos = new Vector3(target.position.x, transform.position.y, target.position.z);
        transform.LookAt(targetPos);
    }

    private void TowerRotate()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
