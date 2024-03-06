using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void Retry()
    {
        SceneManager.LoadScene("AmirScene");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("TestingScene");
    }
}
