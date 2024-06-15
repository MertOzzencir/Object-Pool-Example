using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [SerializeField] private ObjectPool _pool;
    [SerializeField] private int _timer;
    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    IEnumerator SpawnObject()
    {
        int sayac = 0;
        while(true)
        {
            GameObject go = _pool.GetPooledObject(sayac++ % 2);
            
            go.transform.position = Vector3.zero;
            


            yield return new WaitForSeconds(_timer);
        }

    }
}
