using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class bisopini : MonoBehaviour
{
    NavMeshAgent seqeto;
    public GameObject shop;
    void Start()
    {
        seqeto = GetComponent<NavMeshAgent>();
    }

  
    void Update()
    {
        seqeto.SetDestination(shop.transform.position);
    }
}
