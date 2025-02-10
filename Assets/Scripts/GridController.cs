using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{


    private Color originalColor;
    public Color hoverColor = Color.red;

    private void Start()
    {
        originalColor = GetComponent<Renderer>().material.color;
    }

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = hoverColor;
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = originalColor;
    }
}

