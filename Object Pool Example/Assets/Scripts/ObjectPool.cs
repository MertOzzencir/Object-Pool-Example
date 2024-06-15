using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ObjectPool;

public class ObjectPool : MonoBehaviour
{
    [Serializable]
    public struct Pool
    {
        public Queue<GameObject> PooledObject;
        public int PoolSize;
        public GameObject ObjectPrefab;

    }

    public Pool[] pools;


    private void Awake()
    {
        for (int i = 0; i < pools.Length; i++)
        {
            pools[i].PooledObject = new Queue<GameObject>();
            for (int j = 0; j < pools[i].PoolSize; j++)
            {
                GameObject go = Instantiate(pools[i].ObjectPrefab);
                pools[i].PooledObject.Enqueue(go);
                go.SetActive(false);

            }
        }
            
    }

    public GameObject GetPooledObject(int index)
    {

        GameObject obj = pools[index].PooledObject.Dequeue();
        obj.SetActive(true);
        pools[index].PooledObject.Enqueue(obj);
        return obj;
    }

}
