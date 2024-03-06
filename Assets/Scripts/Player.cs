using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Obstacle")
        {
            SceneManager.LoadScene("Lose Scene");
        }
        else if (other.transform.tag == "WinWall")
    {
            SceneManager.LoadScene("Win Scene");
        }
    }

}
