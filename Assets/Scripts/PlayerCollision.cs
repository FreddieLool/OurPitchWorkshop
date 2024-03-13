using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public static event Action<int> PositionUpdate;
    public static event Action PlayerDied;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        PositionUpdate?.Invoke((int)transform.position.x);
    }

    private void OnDestroy()
    {
        PlayerDied?.Invoke();
    }
}
