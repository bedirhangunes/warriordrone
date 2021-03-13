using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class dijimine : MonoBehaviour
{
    public GameObject teres;
    NavMeshAgent agent;
    public GameObject explosi, plExplosi;
    GameObject cotorl;
    qeflaDron qefli;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        cotorl = GameObject.FindGameObjectWithTag("contrl");
        qefli = cotorl.GetComponent<qeflaDron>();
    }

 
    void Update()
    {
        agent.SetDestination(teres.transform.position);
    
    }

     void OnTriggerEnter(Collider col)
    {
        if (col.tag != "xet")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            Instantiate(explosi, transform.position, transform.rotation);
            qefli.comeScro(2);
        }
        if (col.tag == "Player")
        {
            Instantiate(plExplosi, col.transform.position, col.transform.rotation);
            SceneManager.LoadScene("Level 1");

        }
    }


}
