using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class pimpali : MonoBehaviour
{
    public Transform nisan;
    public GameObject droniet;
    public Rigidbody bullibul;
    public float importe = 3000.0f;
    RaycastHit hit;
    float ager = 0;
    bool ctorew = false;
    NavMeshAgent ajt;    void Start()
    {
        ajt = GetComponent<NavMeshAgent>();
    }

   

    void Update()
    {
        ajt.SetDestination(droniet.transform.position);
        drXezRay();
        if (Input.GetMouseButton(0))
        {
            ager += Time.deltaTime;
            if (ager > 0.4f)
            {
                Rigidbody shot = (Rigidbody)Instantiate(bullibul, nisan.position + nisan.forward, nisan.rotation);
                shot.AddForce(nisan.forward * importe, ForceMode.Impulse);
                ager = 0;
            }
            ctorew = true;
        }
    }
    void drXezRay()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if (Physics.Raycast(ray, out hit))
        {

        }
        else
        {

        }
        Debug.DrawRay(ray.origin, ray.GetPoint(1000));
        Debug.DrawLine(nisan.transform.position, hit.point, Color.black);
    }
}

