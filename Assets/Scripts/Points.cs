using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] private TextMeshProUGUI textMeshPro;
    private int distance;
    void FixedUpdate()
    {
        
        textMeshPro.text = "Score: " + distance.ToString();
    }

    public void calculate(int calculator)
    {
        distance = Mathf.Max((int)player.transform.position.x, calculator);
    }
}
