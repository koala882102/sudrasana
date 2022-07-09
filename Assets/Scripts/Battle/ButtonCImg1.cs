using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonCImg1 : MonoBehaviour
{
    
    private bool isOver = false;
    /// <summary>
    /// 要設置的圖集
    /// </summary>
    public Sprite Mysprit;
    /// <summary>
    /// 默認的圖集（自動獲取按鈕默認）
    /// </summary>
    private Sprite Defallsprit;
    /// <summary>
    /// 更改圖片開關
    /// </summary>
    private bool ischange = false;

    public static int round;

    private void Start()
    {
        Defallsprit = transform.GetComponent<Image>().sprite;
    }

    public void OnMouseEnter()
    {
        isOver = true;
        ischange = true;
    }

    public void OnMouseExit()
    {
        isOver = false;
        ischange = false;
    }

    private void Update()
    {
        if (isOver && ischange)
        {
            transform.GetComponent<Image>().sprite = Mysprit;
        }
        else
        {
            transform.GetComponent<Image>().sprite = Defallsprit;
        }

        
    }

    public void OnMouseDown()
    {
        if (Settlement.MyRound)
        {
            round = round + 1;
            Debug.Log(round);
            if (round == 4)
            {
                round = 3;
            }
            Settlement.MyRound = false;
        }
    }
}
