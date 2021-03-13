using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class pimpeli : MonoBehaviour
{
    public GameObject miche;
    NavMeshAgent agentt;
    float agirbe = 0;
    public Transform nishnt;
    public Rigidbody derbt;
    bool qontrl = false;
    RaycastHit hit;
    public float impisid = 1000.0f;
    void Start()
    {
        agentt = GetComponent<NavMeshAgent>();
    }

   
    void Update()
    {
        agentt.SetDestination(miche.transform.position);
        xezbiki();
        if (Input.GetMouseButton(0))
        {
            agirbe += Time.deltaTime;
            if (agirbe > 0.7f)
            {
                Rigidbody salat = (Rigidbody)Instantiate(derbt, nishnt.position + nishnt.forward, nishnt.rotation);
                salat.AddForce(nishnt.forward * impisid, ForceMode.Impulse);
                agirbe = 0;

            }
            qontrl = true;
        }
    }
    void xezbiki()
    {
        Ray reyehli = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if (Physics.Raycast(reyehli, out hit))
        {

        }
        else
        {

        }
        Debug.DrawRay(reyehli.origin, reyehli.GetPoint(1000));
        Debug.DrawLine(nishnt.transform.position, hit.point, Color.green);
    }
}
