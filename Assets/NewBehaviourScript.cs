using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    void Start()
    {
        characterC ez=GameObject.FindGameObjectWithTag("Player").GetComponent<characterC>();
        GetComponent<Rigidbody>().AddForce(ez.noktaCo()*10000);
        transform.rotation=Quaternion.LookRotation(ez.noktaCo());
        Destroy(gameObject,2);
    }

   
}
