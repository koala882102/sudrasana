using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffAppear : MonoBehaviour
{
    private bool isOver = false;

    public GameObject BTG;
    public void OnMouseEnter()
    {
        isOver = true;
    }

    public void OnMouseExit()
    {
        isOver = false;
    }

    private void Update()
    {
        if (isOver)
        {
            //Debug.Log("滑鼠移到上面");
            BTG.SetActive(true);
        }
        else
        {
            BTG.SetActive(false);
        }
    }
}
