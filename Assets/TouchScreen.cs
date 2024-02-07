using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TouchScreen : MonoBehaviour
{
    [SerializeField] Camera _camera;

    [SerializeField] Transform Ink;
    [SerializeField] int poolSize;
    Transform[] drawingPool;

    private void Start()
    {
        drawingPool = new Transform[poolSize];
        for (int i = 0; i < poolSize; i++)
        {
            drawingPool[i] = Instantiate(Ink);
            drawingPool[i].gameObject.SetActive(false);
        }
    }


    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            //drawingPool[0].position = GetPosition();
            //Transform a = Instantiate(Ink);
            Transform a = GetPoolObject();
            if (a != null)
            {
                a.position = GetPosition();

            }
        }
    }

    Transform GetPoolObject()
    {
        for (int i = 0; i < poolSize; i++)
        {
            if (drawingPool[i].gameObject.activeInHierarchy)
            {
                continue;
            }
            drawingPool[i].gameObject.SetActive(true);
            return drawingPool[i];
        }

        return null;
    }

    private Vector2 GetPosition()
    {
        return _camera.ScreenToWorldPoint(Input.mousePosition);
    }
}
