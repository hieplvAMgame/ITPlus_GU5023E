using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolder : MonoBehaviour
{
    public Transform target;
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        Quaternion diff = Quaternion.LookRotation( target.position - transform.position);
        transform.localRotation = Quaternion.Slerp(transform.rotation, diff, rotateSpeed * Time.deltaTime);
    }
}
