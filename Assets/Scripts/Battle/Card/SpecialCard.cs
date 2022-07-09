using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialCard : MonoBehaviour
{
    public static int SpecialCardBuff; //五回合不受傷害
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if (Settlement.MyRound)
        {
            SpecialCardBuff = 1; //五回合不受傷害啟動第一回合
            Settlement.MyRound = false;
        }
    }
}
