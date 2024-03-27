using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public static event Action<int> PositionUpdate;
    public static event Action PlayerDied;

    private void FixedUpdate()
    {
        PositionUpdate?.Invoke((int)transform.position.x);
    }

    private void OnDestroy()
    {
        PlayerDied?.Invoke();
    }
}
