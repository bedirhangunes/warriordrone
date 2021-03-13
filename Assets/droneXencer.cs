using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class droneXencer : MonoBehaviour
{
    float horizontal, vertical,lexe=0;
    Vector3 verc;
    public GameObject shur, nisanet;
    bool cto = false;
    AudioSource souric;
    RaycastHit hit;
    public Text liftext;
    int life = 5;
    Joybutton joybuttonik;
    Joystick joystickim;
    protected bool agerr;
    void Start()
    {
        verc = new Vector3();
        souric = GetComponent<AudioSource>();
        liftext.text = "LIFE: " + life;
        joybuttonik = FindObjectOfType<Joybutton>();
        joystickim = FindObjectOfType<Joystick>();
    }

    
    void Update()
    {
        //dimeshi();
        var rig = GetComponent<Rigidbody>();
        rig.velocity = new Vector3(joystickim.Horizontal * 200f, rig.velocity.y, joystickim.Vertical * 200f);

        xezkdwRay();
        if (!agerr&&joybuttonik.presi)
        {
            lexe += Time.deltaTime;
            if (lexe > 0.4f)
            {
                Instantiate(shur, nisanet.transform.position, Quaternion.identity);
                souric.Play();
                lexe = 0;
            }
            cto = true;
            agerr = true;
        }
        else if (agerr && !joybuttonik.presi)
        {
            cto = false;
            agerr = false;
            lexe = 1;
        }
    }
    //void dimeshi()
    //{
    //    horizontal = Input.GetAxis("Horizontal");
    //    vertical = Input.GetAxis("Vertical");
    //    verc.Set(horizontal, 0, vertical);
    //    transform.Translate(verc*Time.deltaTime*150);
    //}
    void xezkdwRay()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        if(Physics.Raycast(ray ,out hit))
        {

        }
        else
        {

        }
        Debug.DrawRay(ray.origin, ray.GetPoint(1000));
        Debug.DrawLine(nisanet.transform.position, hit.point);
    }
    public Vector3 noqtik()
    {
        return (hit.point - nisanet.transform.position).normalized;
    }
     void OnTriggerEnter(Collider col)
    {
        if (col.tag == "roket")
        {
            life--;
            liftext.text = "LIFE: " + life;
            if (life == 0)
            {
                SceneManager.LoadScene("Level 3");
            }
        }
        if (col.tag == "sinirim")
        {
            SceneManager.LoadScene("Level 3");
        }
    }
}
