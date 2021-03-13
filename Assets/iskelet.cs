using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class iskelet : MonoBehaviour
{
    public Vector3 hestRand;
    public GameObject hestu;
    void Start()
    {
        StartCoroutine(derkevinHol());
    }

 
   IEnumerator derkevinHol()
    {
        yield return new WaitForSeconds(2);
        while (true)
        {
            for(int i = 0; i < 30; i++)
            {
                Vector3 awr = new Vector3(Random.Range(-hestRand.x, hestRand.x), hestRand.y, Random.Range(-hestRand.z,hestRand.z));
                Instantiate(hestu, awr, Quaternion.identity);
                yield return new WaitForSeconds(5);
            }
            yield return new WaitForSeconds(2);
        }
             
    }
}
