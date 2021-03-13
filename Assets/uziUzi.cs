using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class uziUzi : MonoBehaviour
{
    NavMeshAgent uziToDrone;
    public GameObject dron;
    public Transform nisannn;
    public Rigidbody derbt;
    RaycastHit hit;
    float ateeesh = 0;
    public float impul = 2000.0f;
    bool agrctr = false;

    void Start()
    {
        uziToDrone = GetComponent<NavMeshAgent>();
    }

  
    void Update()
    {
        uziToDrone.SetDestination(dron.transform.position);
        reyret();
        if (Input.GetMouseButton(0))
        {
            ateeesh += Time.deltaTime;
            if (ateeesh > 0.6f)
            {
                Rigidbody lex = (Rigidbody)Instantiate(derbt, nisannn.position + nisannn.forward, nisannn.rotation);
                lex.AddForce(nisannn.forward * impul, ForceMode.Impulse);
                ateeesh = 0;
            }
            agrctr = true;
        }
    }
    void reyret()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if(Physics.Raycast(ray,out hit))
        {

        }
        else
        {

        }
        Debug.DrawRay(ray.origin, ray.GetPoint(1000));
        Debug.DrawLine(nisannn.transform.position, hit.point);
    }
}
