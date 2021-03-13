using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class dijm2 : MonoBehaviour
{
  
    public GameObject heron;
    public GameObject patlama1, patlamaDrn;
  
    NavMeshAgent agerayis;
    GameObject puan;
    geymCont controlki;
    void Start()
    {
        agerayis = GetComponent<NavMeshAgent>();
        puan = GameObject.FindGameObjectWithTag("cotiraray");
        controlki = puan.GetComponent<geymCont>();
    }


    void Update()
    {
        agerayis.SetDestination(heron.transform.position);
        
    }

     void OnTriggerEnter(Collider col)
    {
        if (col.tag != "sinirim")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            Instantiate(patlama1, transform.position, transform.rotation);
            controlki.comeScore(2);
        }
        if (col.tag == "Player")
        {
            Instantiate(patlamaDrn, col.transform.position, col.transform.rotation);
            SceneManager.LoadScene("Level 3");
        }
    }
}
