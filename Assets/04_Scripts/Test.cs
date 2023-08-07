using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    GameObject obj;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            obj = ObjectPooling.instance.GetObjectFromPool("Cube");
            obj.transform.position = Vector3.up * 3f;
        }
    }
}
