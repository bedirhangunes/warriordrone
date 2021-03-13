using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class dijminct : MonoBehaviour
{
    public GameObject armanch;
    NavMeshAgent intelligience;
    void Start()
    {
        intelligience = GetComponent<NavMeshAgent>();
    }

  
    void Update()
    {
        intelligience.SetDestination(armanch.transform.position);
    }
}
