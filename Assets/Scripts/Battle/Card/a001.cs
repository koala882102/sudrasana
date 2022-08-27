using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a001 : MonoBehaviour
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
            GameMgr.MyCardType = 1; //我方出攻擊牌
            GameMgr.MyAttackTimes = 1;
            if (GameMgr.Distance <= 3) //距離小於3
            {
                //Debug.Log(GameMgr.Distance);
                GameMgr.ThisRoundDamage = GameMgr.ThisRoundDamage + 10;
                Debug.Log(GameMgr.ThisRoundDamage);
            }

            Settlement.MyRound = false;
            Destroy(gameObject);
        }
    }
}
