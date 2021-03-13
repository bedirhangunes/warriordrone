using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ctrlDijmin : MonoBehaviour
{
   public Vector3 randomb;
    public GameObject soldierss;

    int score = 0;
    public Text scrtex;
    void Start()
    {
        StartCoroutine(createD());
        scrtex.text = "SCORE : " + score;
    }

  
  IEnumerator createD()
    {
        yield return new WaitForSeconds(2);
        while (true)
        {
            for(int i = 0; i < 20; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomb.x, randomb.x), randomb.y, Random.Range(-randomb.z, randomb.z));
                Instantiate(soldierss, vec, Quaternion.identity);
                yield return new WaitForSeconds(6);
            }
            yield return new WaitForSeconds(4);
        }

    }

    public void scrTexy(int dScr)
    {
        score += dScr;
        scrtex.text = "SCORE: " + score;
        if (score == 12)
        {
            SceneManager.LoadScene("Level 2");
        }
    }
}
