using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public Vector3 offSet;

    private void Update()
    {
        transform.position = new Vector3(player.position.x + offSet.x, player.position.y + offSet.y, player.position.z + offSet.z);
    }
}
