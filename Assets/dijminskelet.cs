using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class dijminskelet : MonoBehaviour
{
    NavMeshAgent skelet;
    public GameObject amanc;
 public   GameObject exp11, expDrn;
    GameObject scorz;
    geymCont scorzede;
    void Start()
    {
        skelet = GetComponent<NavMeshAgent>();
        scorz = GameObject.FindGameObjectWithTag("cotrl");
        scorzede = scorz.GetComponent<geymCont>();

    }

  
    void Update()
    {
        skelet.SetDestination(amanc.transform.position);
    }
     void OnTriggerEnter(Collider col)
    {
        if (col.tag != "sinirim")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            Instantiate(exp11, transform.position, transform.rotation);
            scorzede.comeScore(2);
        }
        if (col.tag == "Player")
        {
            Instantiate(expDrn, col.transform.position, col.transform.rotation);
            SceneManager.LoadScene("Level 3");
        }

    }
    
}
