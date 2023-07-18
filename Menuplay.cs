using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menuplay : MonoBehaviour
{ 
    public void play()
    {
        SceneManager.GetActiveScene();
        Time.timeScale = 1f;
    }
    public void Restartlvl()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
    public void ExittoMenu()
    {
        SceneManager.LoadScene(0);
    }
   
}
