using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class question : MonoBehaviour
{
    private bool isOver = false;
    public GameObject q;
    public void OnMouseEnter()
    {
        isOver = true;
    }

    public void OnMouseExit()
    {
        isOver = false;
    }

    public void Update()
    {
        if (isOver)
        {
            q.SetActive(true);
        }
        else
        {
            q.SetActive(false);
        }
    }
}
