using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class keleskofi : MonoBehaviour
{
    public GameObject armnc;
    NavMeshAgent agenti;
    public Transform nishn;
    public Rigidbody bullshit;
    RaycastHit hit;
    float agiri = 0;
    bool ctore = false;
    public float impi = 2000.0f;
    void Start()
    {
        agenti = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        agenti.SetDestination(armnc.transform.position);
        drawReye();
        if (Input.GetMouseButton(0))
        {
            agiri += Time.deltaTime;
            if (agiri > 0.35f)
            {
                Rigidbody bulls = (Rigidbody)Instantiate(bullshit, nishn.position + nishn.forward, nishn.rotation);
                bulls.AddForce(nishn.forward * impi, ForceMode.Impulse);
                agiri = 0;
            }
            ctore = true;
        }


    }
    void drawReye()
    {
        Ray rray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if(Physics.Raycast(rray,out hit))
        {
            Debug.Log("dite");
        }
        else
        {
            Debug.Log("nedit");
        }
        Debug.DrawRay(rray.origin, rray.GetPoint(1000));
        Debug.DrawLine(nishn.transform.position, hit.point, Color.red);
    }
}
