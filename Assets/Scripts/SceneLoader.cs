using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static event Action GameStarted;

    private int sceneCounter = 0;
    public void StartStage()
    {
        if (sceneCounter == 0)
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1.0f;
        }
        else if (sceneCounter == 1)
        {
            SceneManager.LoadScene("AmirScene2");
            Time.timeScale = 1.0f;
        }   
        GameStarted?.Invoke();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
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
