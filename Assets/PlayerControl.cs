using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerControl : MonoBehaviour
{
    float horizontal, vertical,agir=0;
    Vector3 vect;
    bool ctrlbull = false;
    public GameObject nisangeh, derbbull;
    RaycastHit hit;
    AudioSource sorchi;
    public Text textLfe;
    int life = 7;
    Joybutton joybuttoni;
    Joystick joysticki;
    protected bool agire;
    void Start()
    {
        vect = new Vector3();
        sorchi = GetComponent<AudioSource>();
        textLfe.text = "LIFE: " + life;
        joybuttoni = FindObjectOfType<Joybutton>();
        joysticki = FindObjectOfType<Joystick>();
    }

   
    void Update()
    {
        //hareketii();
        var rigid = GetComponent<Rigidbody>();
        rigid.velocity = new Vector3(joysticki.Horizontal * 350f, rigid.velocity.y, joysticki.Vertical * 350f);
        rayxezzzzz();
        if (!agire&& joybuttoni.presi)
        {
            agir += Time.deltaTime;
            if (agir > 0.3f)
            {
                Instantiate(derbbull, nisangeh.transform.position, Quaternion.identity);
                sorchi.Play();
                agir = 0;

            }
            ctrlbull = true;
            agire = true;
        }
        else if(agire&& !joybuttoni.presi)
        {
            ctrlbull = false;
            agire = false;
            agir = 1;
        }
    }
    //void hareketii()
    //{
    //    horizontal = Input.GetAxis("Horizontal");
    //    vertical = Input.GetAxis("Vertical");
    //    vect.Set(horizontal, 0, vertical);
    //    transform.Translate(vect*Time.deltaTime*350);
    //}
    void rayxezzzzz()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if(Physics.Raycast(ray,out hit))
        {

        }
        else
        {

        }
        Debug.DrawRay(ray.origin, ray.GetPoint(1000));
        Debug.DrawLine(nisangeh.transform.position, hit.point);
    }
    public Vector3 gotoPo()
    {
        return (hit.point - nisangeh.transform.position).normalized;
    }
     void OnTriggerEnter(Collider col)
    {
        if (col.tag == "lif")
        {
            life--;
            textLfe.text = "LIFE: " + life;
            if (life == 0)
            {
                SceneManager.LoadScene("Level 2");
            }
        }
        if (col.tag == "xet")
        {
            SceneManager.LoadScene("Level 2");
        }
    }
}
