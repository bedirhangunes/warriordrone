using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qotral : MonoBehaviour
{
  
    void Start()
    {
        bimeshi dro = GameObject.FindGameObjectWithTag("Player").GetComponent<bimeshi>();
        GetComponent<Rigidbody>().AddForce(dro.goComeNiqt() * 2000);
        transform.rotation = Quaternion.LookRotation(dro.goComeNiqt());

        Destroy(gameObject, 5);
    }

 
}
