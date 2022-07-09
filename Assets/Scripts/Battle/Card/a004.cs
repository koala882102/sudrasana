using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a004 : MonoBehaviour
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
            GameMgr.MyCardType = 3;
            GameMgr.MyLocation = GameMgr.MyLocation + 3;
            if (GameMgr.MyLocation == GameMgr.EnemyLocation)
            {
                GameMgr.MyLocation = GameMgr.EnemyLocation - 1;
            }
            BuffText.B1TR = BuffText.B1TR + 1;
            BuffText.B1TN = BuffText.B1TN + 3;
            Settlement.b1.SetActive(true);
            
            Settlement.MyRound = false;
        }
    }
}
