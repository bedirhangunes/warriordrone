using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class qeflaDron : MonoBehaviour
{
    public GameObject dronE;
    public Vector3 randomique;
    int scort = 0;
    public Text texScr;

    void Start()
    {

        StartCoroutine(creyted());
        texScr.text = "SCORE: " + scort;
    }

  
   IEnumerator creyted()
    {
        yield return new WaitForSeconds(3);
        while (true)
        {
            for(int d = 0; d < 20; d++)
            {
                Vector3 drn = new Vector3(Random.Range(-randomique.x, randomique.x), randomique.y, Random.Range(-randomique.z, randomique.z));
                Instantiate(dronE, drn, Quaternion.identity);
                yield return new WaitForSeconds(3);
            }
            yield return new WaitForSeconds(5);
        }

    }
    public void comeScro(int skor)
    {
        scort += skor;
        texScr.text = "SCORE: " + scort;
        if (scort == 34)
        {
            SceneManager.LoadScene("Level 3");
        }

    }
}
