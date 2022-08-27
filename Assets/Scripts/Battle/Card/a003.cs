using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a003 : MonoBehaviour
{

    public static int a003Buff;
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
            if (GameMgr.EnemyCardType == 1) //若對方為攻擊牌
            {
                a003Buff = 1; //敵方下回合麻痺
            }
            Settlement.MyRound = false;
            Destroy(gameObject);
        }
    }
}
