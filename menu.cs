using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    public GameObject menu;
    public GameObject SettingsMenu;
    // Start is called before the first frame update
    public void Play()
    {
        SceneManager.LoadScene(1);
        
    }
    public void Settings()
    {
        menu.SetActive(false);
        SettingsMenu.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
