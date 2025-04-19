using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Shoot : MonoBehaviour
{
    [SerializeField] Transform muzzlePoint;
    
    [SerializeField] ObjectPool objectPool;

    [SerializeField] private int bulletSpeed;



    public void Fire()
    {
        PooledObject instance = objectPool.CreateBullet(muzzlePoint.position,muzzlePoint.rotation);
        Rigidbody bulletRigidbody = instance.GetComponent<Rigidbody>();
        bulletRigidbody.velocity = muzzlePoint.forward * bulletSpeed;
    }

    public void Fire(float chargeSpeed)
    {
        PooledObject instance = objectPool.CreateBullet(muzzlePoint.position, muzzlePoint.rotation);
        Rigidbody bulletRigidbody = instance.GetComponent<Rigidbody>();
        bulletRigidbody.velocity = muzzlePoint.forward * chargeSpeed;
    }

}
