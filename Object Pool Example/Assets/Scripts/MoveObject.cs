using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class MoveObject : MonoBehaviour
{

    private void Update()
    {
        transform.Translate(transform.forward * 12f * Time.deltaTime);
        
    }
}
