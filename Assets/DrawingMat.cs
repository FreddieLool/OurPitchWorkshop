using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawingMat : MonoBehaviour
{
    [SerializeField] float lifetime;
    private void OnEnable()
    {
        Invoke(nameof(DelayDisable), lifetime);
    }

    void DelayDisable()
    {
        gameObject.SetActive(false);
    }
}
