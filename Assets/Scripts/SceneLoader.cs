using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private int sceneCounter = 0;
    public void Retry()
    {
        if (sceneCounter == 0)
            SceneManager.LoadScene("AmirScene");
        else if (sceneCounter == 1)
            SceneManager.LoadScene("AmirScene2");
    }

    public void NextLevel()
    {
        sceneCounter++;
        SceneManager.LoadScene("AmirScene2");
    }
}
