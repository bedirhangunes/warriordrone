using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class characterC : MonoBehaviour
{
 Vector3 vect;
    float horizontal,vertical,roots,atess=0;
    public GameObject nisan,derbp;
    bool agirrrr=false;
    RaycastHit hit;
    AudioSource fre;
    Joybutton joybutton;
    Joystick joystick;
    protected bool fayir;
    void Start()
    {
        vect=new Vector3();
        fre = GetComponent<AudioSource>();
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<Joybutton>();
    }

   
    void Update()
    {
        // hareketete();
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(joystick.Horizontal * 300f, rigidbody.velocity.y, joystick.Vertical * 300f);


        reyrayy();
        if(!fayir&&joybutton.presi)
        {
        atess+=Time.deltaTime;
            if(atess>0.5f)
            {
                Instantiate(derbp,nisan.transform.position,Quaternion.identity);
                fre.Play();
                atess=0;
            }
            agirrrr=true;
            fayir = true;
        }
        else if(fayir&& !joybutton.presi)
        {
            agirrrr = false;
            fayir = false;
            atess = 1;
        }
    }
    //void hareketete(){

    //    horizontal=Input.GetAxis("Horizontal");
    //    vertical=Input.GetAxis("Vertical");
    //    vect.Set(horizontal,0,vertical);
    //    transform.Translate(vect*Time.deltaTime*300);
    //}
    void reyrayy()
    {
        Ray rrrr=Camera.main.ViewportPointToRay(new Vector3(0.5f,0.5f,0));
        if(Physics.Raycast(rrrr,out hit)){

        }
        else
        {

        }
        Debug.DrawRay(rrrr.origin,rrrr.GetPoint(1000));
        Debug.DrawLine(nisan.transform.position,hit.point);
    }
    public Vector3 noktaCo()
    {
        return (hit.point-nisan.transform.position).normalized;
    }
     void OnTriggerEnter(Collider col)
    {
       
        if(col.tag != "xetamirine")
        {
            SceneManager.LoadScene("Level 1");
        }
    }
}
