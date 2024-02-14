using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawner : MonoBehaviour
{
    Renderer renderer;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    private void Despawn()
    {
        Destroy(this.gameObject);
    }

    private void Update()
    {
        if (!renderer.isVisible)
            Despawn();
    }
}
