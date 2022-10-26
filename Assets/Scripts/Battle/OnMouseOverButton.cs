using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class OnMouseOverButton : MonoBehaviour
{
    private bool isOver = false;
    public GameObject opencard1;
    public GameObject SpecialSkill;

    public AudioMgr audiomgr;
    public void OnMouseEnter()
    {
        isOver = true;
    }

    public void OnMouseExit()
    {
        isOver = false;
    }

    public void OnMouseDown()
    {
        audiomgr.pressbutton();
        if (Settlement.MyRound &&　ButtonCImg1.round == 3)
        {
            SpecialSkill.SetActive(true);
            Invoke("OpenSpecialSkill",3);
            ButtonCImg1.round = 0;
        }
    }

    public void OpenSpecialSkill()
    {
        SpecialSkill.SetActive(false);
    }

    private void Update()
    {
        if (isOver)
        {
            //Debug.Log("滑鼠移到上面");
            opencard1.SetActive(true);
        }
        else
        {
            opencard1.SetActive(false);
        }
    }
}
