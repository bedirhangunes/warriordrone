using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class erishkerduwe : MonoBehaviour
{
    NavMeshAgent agen;
    public GameObject kerekt;
    void Start()
    {
        agen = GetComponent<NavMeshAgent>();
    }

   
    void Update()
    {
        agen.SetDestination(kerekt.transform.position);
    }
}
