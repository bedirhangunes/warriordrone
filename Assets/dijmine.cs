using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class dijmine : MonoBehaviour
{
    NavMeshAgent hoppp;

    public GameObject berxe;
    void Start()
    {
        hoppp = GetComponent<NavMeshAgent>();
    }

  
    void Update()
    {


        hoppp.SetDestination(berxe.transform.position);
        
    }
   

}
