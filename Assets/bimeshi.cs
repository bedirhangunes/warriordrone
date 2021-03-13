using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bimeshi : MonoBehaviour
{
    float horizontal, vertical,erish=0;
    Vector3 vectir;
    RaycastHit hit;
    public GameObject bulled, nisanghet;
    bool kuntrul=false;

    void Start()
    {
        vectir = new Vector3();
    }

  
    void Update()
    {
        hereketiqueded();
        reyrayray();
        if (Input.GetMouseButton(0))
        {
            erish += Time.deltaTime;
            if (erish > 0.45f)
            {
                Instantiate(bulled, nisanghet.transform.position, Quaternion.identity);
                erish = 0;
            }
            kuntrul = true;
        }
    }
    void hereketiqueded()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        vectir.Set(horizontal, 0, vertical);
        transform.Translate(vectir * Time.deltaTime * 200);
    }
    void reyrayray()
    {
        Ray reyeh = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if(Physics.Raycast(reyeh,out hit))
        {

        }
        else
        {

        }
        Debug.DrawRay(reyeh.origin, reyeh.GetPoint(1000));
        Debug.DrawLine(nisanghet.transform.position,hit.point);
    }
    public Vector3 goComeNiqt() 
    {
        return (hit.point - nisanghet.transform.position).normalized;
    }
}
