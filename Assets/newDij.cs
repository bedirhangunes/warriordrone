using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
public class newDij : MonoBehaviour
{
    NavMeshAgent meshede;
    public GameObject armancc;
    public GameObject teq1, teqPly;
    GameObject scrZede;
    ctrlDijmin dijm;
  
    void Start()
    {
        meshede = GetComponent<NavMeshAgent>();
        scrZede = GameObject.FindGameObjectWithTag("qiyamete");
        dijm = scrZede.GetComponent<ctrlDijmin>();
    }

    void Update()
    {
        meshede.SetDestination(armancc.transform.position);
    }
     void OnTriggerEnter(Collider col)
    {
        if (col.tag != "xetamirine")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
            Instantiate(teq1, transform.position,transform.rotation);
            dijm.scrTexy(2);
        }
        if (col.tag == "Player")
        {
            Instantiate(teqPly, col.transform.position, col.transform.rotation);
            SceneManager.LoadScene("MainMenu");
        }
    }
}
