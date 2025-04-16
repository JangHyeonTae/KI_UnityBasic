using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlePool : MonoBehaviour
{
    [SerializeField] private PooledParticle particlePool;
    [SerializeField] private List<PooledParticle> pool;
    [SerializeField] int size;

    private void Awake()
    {
        for(int i = 0; i<size; i++)
        {

        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
