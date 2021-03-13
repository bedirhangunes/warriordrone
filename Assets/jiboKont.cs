using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class jiboKont : MonoBehaviour
{
    public GameObject hefd;
    NavMeshAgent zerr;
    public Transform nisanhi;
    public Rigidbody bullshitt;
    bool contr = false;
    float zemaneAgir = 0,impulsed=3000.0f;
    
    RaycastHit hit;


    void Start()
    {
        zerr = GetComponent<NavMeshAgent>();
    }

   
    void Update()
    {
       
        zerr.SetDestination(hefd.transform.position);
        reyXezkirn();
        if (Input.GetMouseButton(0))
        {
            zemaneAgir += Time.deltaTime;
            if (zemaneAgir > 0.5f)
            {
                Rigidbody shoop = (Rigidbody)Instantiate(bullshitt, nisanhi.position + nisanhi.forward, nisanhi.rotation);

               shoop.AddForce(nisanhi.forward * impulsed, ForceMode.Impulse);
                zemaneAgir = 0;
            }
          
            contr = true;
        }

    }
     void FixedUpdate()
    {
        //int layerMask = 1 << 8;
        //layerMask = ~layerMask;
        //if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit, Mathf.Infinity, layerMask))
        //{
        //    Debug.DrawRay(transform.position,transform.TransformDirection(Vector3.forward)*hit.distance,Color.red);

        //}
        //else
        //{
        //    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.black);
        //}
        //if(Physics.Raycast(transform.position,-Vector3.up,out hit, 100.0f))
        //{
        //    print("Found an object - distance : " + hit.distance);
        //}
    }
    void reyXezkirn()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if(Physics.Raycast(ray,out hit))
        {

        }
        else
        {

        }
        Debug.DrawRay(ray.origin, ray.GetPoint(1000));
        Debug.DrawLine(nisanhi.transform.position, hit.point, Color.blue);
    }

}
