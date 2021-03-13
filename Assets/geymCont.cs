using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class geymCont : MonoBehaviour
{
    public Vector3 randmt;
    public GameObject skleti;
    public Text skorText;
    int skorema = 0;
 
    void Start()
    {
        StartCoroutine(croted());
        skorText.text = "SCORE: " + skorema;
    }

 
  IEnumerator croted()
    {
        yield return new WaitForSeconds(2);
        while (true)
        {
            for(int i = 0; i < 50; i++)
            {
                Vector3 shiv = new Vector3(Random.Range(-randmt.x, randmt.x), randmt.y, Random.Range(-randmt.z, randmt.z));
                Instantiate(skleti, shiv, Quaternion.identity);
                yield return new WaitForSeconds(4);
                
            }
            yield return new WaitForSeconds(5);
        }
    }
    public void comeScore(int gScor)
    {
        skorema += gScor;
        skorText.text = "SCORE: " + skorema;
        if (skorema == 50)
        {
            SceneManager.LoadScene("MainMenu");

        }
    }
}
