using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a002 : MonoBehaviour
{

    public static int a002Buff;

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
            GameMgr.MyCardType = 1; //我方出攻擊牌
            GameMgr.MyAttackTimes = 1;
            if (GameMgr.Distance <= 5)
            {
                GameMgr.ThisRoundDamage = GameMgr.ThisRoundDamage + 5;
                BuffText.B1TR = BuffText.B1TR + 1; //振奮回合+1
                BuffText.B1TN = BuffText.B1TN + 5; //振奮+5
                a002Buff = 1; //下回合虛弱啟動
                Settlement.b1.SetActive(true);
            }
            Settlement.MyRound = false;
        }
    }
}
