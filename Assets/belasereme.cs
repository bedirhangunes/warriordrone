using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class belasereme : MonoBehaviour
{
    public Vector3 ciheDerketine;
    public GameObject solde;

    void Start()
    {
        StartCoroutine(creatoriy());
    }

   
  IEnumerator creatoriy()
    {
        yield return new WaitForSeconds(1);
        while (true)
        {
            for(int i = 0; i < 25; i++)
            {
                Vector3 brao = new Vector3(Random.Range(-ciheDerketine.x, ciheDerketine.x), ciheDerketine.y, Random.Range(-ciheDerketine.z,ciheDerketine.z));
                Instantiate(solde, brao, Quaternion.identity);
                yield return new WaitForSeconds(2);
            }
            yield return new WaitForSeconds(3);
        }
    }
}
