using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lexelo : MonoBehaviour
{
     void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
