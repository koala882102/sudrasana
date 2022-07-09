using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b006 : MonoBehaviour
{
    public static int b006Buff;

    public Settlement Settlement;
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
            GameMgr.MyCardType = 1;
            GameMgr.MyAttackTimes = 1;
            if (GameMgr.Distance <= 5)
            {
                GameMgr.ThisRoundDamage = GameMgr.ThisRoundDamage + 3;
                BuffText.B1TR = BuffText.B1TR + 1;
                BuffText.B1TN = BuffText.B1TN + 3;
                Settlement.b1.SetActive(true);
                if (GameMgr.HaveBuff >= 1 && GameMgr.EHaveBuff >= 1)
                {
                    b006Buff = 1; //下回合雙方亢奮3啟動
                }
            }
            Settlement.MyRound = false;
        }
    }
}
