using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class c005 : MonoBehaviour
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
            GameMgr.MyLocation = GameMgr.MyLocation + 5;
            if (GameMgr.MyLocation >= GameMgr.EnemyLocation)
            {
                GameMgr.MyLocation = GameMgr.EnemyLocation - 1;
            }
            BuffText.B5TR = BuffText.B5TR + 1;
            BuffText.B5TN = BuffText.B5TN + 3;
            Settlement.b5.SetActive(true);
            if (GameMgr.HaveBuff >= 1 && GameMgr.EHaveBuff >= 1)
            {
                BuffText.EB2TR = BuffText.EB2TR + 3;
                BuffText.EB2TN = BuffText.EB2TN + 3;
                Settlement.eb2.SetActive(true);
            }
            Settlement.MyRound = false;
            Destroy(gameObject);
        }
    }
}
