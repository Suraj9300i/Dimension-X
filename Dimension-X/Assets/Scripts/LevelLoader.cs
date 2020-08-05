using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void getGamePlay()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void getStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void quitApp()
    {
        Application.Quit();
    }
}
