using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b008 : MonoBehaviour
{
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
            GameMgr.MyCardType = 2;
            GameMgr.MyDefenseTimes = 1;
            GameMgr.MyLocation = GameMgr.MyLocation + 2;
            if (GameMgr.MyLocation == GameMgr.EnemyLocation)
            {
                GameMgr.MyLocation = GameMgr.MyLocation - 1;
            }
            BuffText.EB6TR = BuffText.EB6TR + 3;
            BuffText.EB6TN = BuffText.EB6TN + 3;
            Settlement.eb6.SetActive(true);
            if (GameMgr.HaveBuff >= 1 && GameMgr.EHaveBuff >= 1)
            {
                GameMgr.ThisRoundDamage = GameMgr.ThisRoundDamage + 5;
            }
            Settlement.MyRound = false;
        }
    }
}
