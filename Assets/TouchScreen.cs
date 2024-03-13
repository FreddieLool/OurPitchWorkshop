using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TouchScreen : MonoBehaviour
{
    private bool isEditor;
    [SerializeField] Camera _camera;

    [SerializeField] Transform Ink;
    [SerializeField] int poolSize;
    [SerializeField] GameObject TouchScreenObject;
    [SerializeField] GameObject ProjectScreenObject;
    Transform[] drawingPool;

    Vector3 screenHeight;
    bool draw = false;
    private PointerEventData m_PointerEventData;
    [SerializeField] private EventSystem m_EventSystem;
    [SerializeField] private GraphicRaycaster m_Raycaster;

    private void Start()
    {
#if UNITY_EDITOR
        isEditor = true;
#else
        isEditor = false;
#endif
        screenHeight = new(0, Screen.height / 2, 0);

        drawingPool = new Transform[poolSize];
        for (int i = 0; i < poolSize; i++)
        {
            drawingPool[i] = Instantiate(Ink);
            drawingPool[i].gameObject.SetActive(false);

        }
    }

    private void Update()
    {
        if (isEditor)
        {
            if (Input.GetMouseButton(0))
            {
                draw = true;
            }
            else draw = false;
        }
        else
        {
            if (Input.touchCount > 0)
            {
                draw = true;
            }
            else draw = false;
        }
    }

    private void FixedUpdate()
    {
        if (draw)
        {
            //drawingPool[0].position = GetPosition();
            //Transform a = Instantiate(Ink);
            Transform a = GetPoolObject();
            if (a != null)
            {
                a.position = ProjectToScreen(BadGetMousePosition());

            }
        }
    }

    Vector2 ProjectToScreen(Vector2 v)
    {
        return new(v.x, v.y);
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

    private Vector2 GetMousePosition()
    {
        //Set up the new Pointer Event
        m_PointerEventData = new PointerEventData(m_EventSystem);
        //Set the Pointer Event Position to that of the game object
        m_PointerEventData.position = Input.mousePosition;

        //Create a list of Raycast Results
        List<RaycastResult> results = new List<RaycastResult>();

        //Raycast using the Graphics Raycaster and mouse click position
        m_Raycaster.Raycast(m_PointerEventData, results);

        if (results.Count > 0)
        {
            //Debug.Log("Hit " + results[0].gameObject.name);
        }
        return _camera.ScreenToWorldPoint(Input.mousePosition);
    }

    private Vector2 BadGetMousePosition()
    {
        if (isEditor)
        {
            return _camera.ScreenToWorldPoint(Input.mousePosition + screenHeight);

        }
        else
        {
            return _camera.ScreenToWorldPoint(Input.GetTouch(0).position + (Vector2)screenHeight);
        }
    }
}
