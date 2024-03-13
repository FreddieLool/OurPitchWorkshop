using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    public Transform player;
    public Vector3 offSet;

    bool playerIsAlive;

    private void Update()
    {
        if (playerIsAlive)
        {
            transform.position = new Vector3(player.position.x + offSet.x, player.position.y + offSet.y, transform.position.z);

        }
    }

    void TogglePlayerDeath()
    {
        playerIsAlive = !playerIsAlive;
    }
}
