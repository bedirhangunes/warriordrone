using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qontroli : MonoBehaviour
{
  
    void Start()
    {
        PlayerControl ctr = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControl>();
        GetComponent<Rigidbody>().AddForce(ctr.gotoPo() * 5000);
        transform.rotation = Quaternion.LookRotation(ctr.gotoPo());
        Destroy(gameObject, 3);
    }

    
}
