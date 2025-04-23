using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class ObjectPool : MonoBehaviour
{
    //List<GameObject> pool;
    //[SerializeField] private int poolSize;
    //[SerializeField] GameObject bulletPrefab;
    //[SerializeField] Transform muzzlePosition;
    //[SerializeField] float timer;
    //
    //public Coroutine fireCor;
    //private YieldInstruction delay;
    //
    //private void Start()
    //{
    //    delay = new WaitForSeconds(timer);
    //    pool = new List<GameObject>();
    //
    //    for (int i = 0; i < poolSize; i++)
    //    {
    //        GameObject bullet = Instantiate(bulletPrefab);
    //        bullet.GetComponent<Bullet>().bulletPool = pool;
    //        pool.Add(bullet);
    //        bullet.SetActive(false);
    //    }
    //
    //    if (fireCor == null)
    //    {
    //        fireCor = StartCoroutine(Fire());
    //    }
    //}
    //
    //public IEnumerator Fire()
    //{
    //    if (pool.Count <= 0) yield return null;
    //
    //    while (true)
    //    {
    //        //인스턴스로 생성
    //        CreateBullet();
    //        yield return delay;
    //    }
    //}
    //
    //private void CreateBullet()
    //{
    //    GameObject bullet = pool[pool.Count - 1];
    //    pool.RemoveAt(pool.Count - 1);
    //
    //    bullet.transform.position = muzzlePosition.position;
    //    bullet.transform.forward = transform.forward;
    //    bullet.SetActive(true);
    //}

}
