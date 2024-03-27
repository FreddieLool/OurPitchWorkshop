using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] private TextMeshProUGUI textMeshPro;
    private int distance;

    private void Start()
    {
        PlayerCollision.PositionUpdate += calculate;
    }

    private void OnDestroy()
    {
        PlayerCollision.PositionUpdate -= calculate;
    }

    void FixedUpdate()
    {

        textMeshPro.text = "Score: " + distance.ToString();
    }

    public void calculate(int calculator)
    {
        distance = Mathf.Max(distance, calculator);
    }
}
