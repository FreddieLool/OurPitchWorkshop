using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject loseUI;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Obstacle")
        {
            player.SetActive(false);
            loseUI.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (other.transform.tag == "WinWall")
    {
            SceneManager.LoadScene("Win Scene");
        }
    }

}
