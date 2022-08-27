using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b009 : MonoBehaviour
{
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
            if (GameMgr.Distance <= 3)
            {
                GameMgr.EnemyHealth = GameMgr.EnemyHealth -
                                      (8 + BuffText.B3TN + BuffText.EB2TN - BuffText.B4TN -
                                       BuffText.B1TN); //卡牌攻擊力+我方亢奮+敵方脆弱-我方虛弱-敵方振奮
            }
            Settlement.MyRound = false;
            Destroy(gameObject);
        }
    }
}
