using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private int sceneCounter = 0;
    public void StartStage()
    {
        if (sceneCounter == 0)
        {
            SceneManager.LoadScene("AmirScene");
            Time.timeScale = 1.0f;
        }
        else if (sceneCounter == 1)
        {
            SceneManager.LoadScene("AmirScene2");
            Time.timeScale = 1.0f;
        }   
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        sceneCounter = 0;
    }
    public void NextLevel()
    {
        sceneCounter++;
        SceneManager.LoadScene("AmirScene2");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
