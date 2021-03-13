using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ComeToStart : MonoBehaviour
{
   
    public void strting()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void exitedi()
    {
        Application.Quit();
    }
    
}
