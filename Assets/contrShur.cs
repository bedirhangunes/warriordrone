using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contrShur : MonoBehaviour
{
   
    void Start()
    {
        droneXencer shr = GameObject.FindGameObjectWithTag("Player").GetComponent<droneXencer>();
        GetComponent<Rigidbody>().AddForce(shr.noqtik() * 3000);
        transform.rotation = Quaternion.LookRotation(shr.noqtik());
        Destroy(gameObject, 2);
    }

  
}
