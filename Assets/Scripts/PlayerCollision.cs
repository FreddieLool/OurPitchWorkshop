using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public static event Action<int> PositionUpdate;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Obstacle")
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        PositionUpdate.Invoke((int)transform.position.x);
    }

}
