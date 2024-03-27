using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    public Transform player;
    public Vector3 offSet;

    bool playerIsAlive = true;

    private void Start()
    {
        PlayerCollision.PlayerDied += PlayerDeath;
        SceneLoader.GameStarted += PlayerAlive;
    }

    private void OnDestroy()
    {
        PlayerCollision.PlayerDied -= PlayerDeath;
        SceneLoader.GameStarted -= PlayerAlive;
        
    }

    private void Update()
    {
        if (playerIsAlive)
        {
            transform.position = new Vector3(player.position.x + offSet.x, player.position.y + offSet.y, transform.position.z);

        }
    }

    void PlayerDeath()
    {
        playerIsAlive = false;
    }

    void PlayerAlive()
    {
        playerIsAlive = true;
    }
}
