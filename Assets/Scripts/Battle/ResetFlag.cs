using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetFlag : MonoBehaviour
{
    public GameObject flag;

    public GameObject Eflag;
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
            flag.transform.localPosition = new Vector3(-255, 7, 405.4f);
            GameMgr.MyLocation = 4;
            //Debug.Log("按鈕按下重製距離");
            Eflag.transform.localPosition = new Vector3(269, 7, 405.4f);
            GameMgr.EnemyLocation = 10;
            Settlement.MyRound = false;
        }
    }

    public void SetFlag()
    {
        if (GameMgr.MyLocation == 1)
        {
            flag.transform.localPosition = new Vector3(-517, 7, 405.4f);
        }else if (GameMgr.MyLocation == 2)
        {
            flag.transform.localPosition = new Vector3(-427, 7, 405.4f);
        }else if (GameMgr.MyLocation == 3)
        {
            flag.transform.localPosition = new Vector3(-340, 7, 405.4f);
        }else if (GameMgr.MyLocation == 4)
        {
            flag.transform.localPosition = new Vector3(-255, 7, 405.4f);
        }else if (GameMgr.MyLocation == 5)
        {
            flag.transform.localPosition = new Vector3(-165, 7, 405.4f);
        }else if (GameMgr.MyLocation == 6)
        {
            flag.transform.localPosition = new Vector3(-80, 7, 405.4f);
        }else if (GameMgr.MyLocation == 7)
        {
            flag.transform.localPosition = new Vector3(7, 7, 405.4f);
        }else if (GameMgr.MyLocation == 8)
        {
            flag.transform.localPosition = new Vector3(94, 7, 405.4f);
        }else if (GameMgr.MyLocation == 9)
        {
            flag.transform.localPosition = new Vector3(184, 7, 405.4f);
        }else if (GameMgr.MyLocation == 10)
        {
            flag.transform.localPosition = new Vector3(269, 7, 405.4f);
        }else if (GameMgr.MyLocation == 11)
        {
            flag.transform.localPosition = new Vector3(354, 7, 405.4f);
        }else if (GameMgr.MyLocation == 12)
        {
            flag.transform.localPosition = new Vector3(444, 7, 405.4f);
        }else if (GameMgr.MyLocation == 13)
        {
            flag.transform.localPosition = new Vector3(531, 7, 405.4f);
        }
        
        if (GameMgr.EnemyLocation == 1)
        {
            Eflag.transform.localPosition = new Vector3(-517, 7, 405.4f);
        }else if (GameMgr.EnemyLocation == 2)
        {
            Eflag.transform.localPosition = new Vector3(-427, 7, 405.4f);
        }else if (GameMgr.EnemyLocation == 3)
        {
            Eflag.transform.localPosition = new Vector3(-340f, 7, 405.4f);
        }else if (GameMgr.EnemyLocation == 4)
        {
            Eflag.transform.localPosition = new Vector3(-255f, 7, 405.4f);
        }else if (GameMgr.EnemyLocation == 5)
        {
            Eflag.transform.localPosition = new Vector3(-165f, 7, 405.4f);
        }else if (GameMgr.EnemyLocation == 6)
        {
            Eflag.transform.localPosition = new Vector3(-80f, 7, 405.4f);
        }else if (GameMgr.EnemyLocation == 7)
        {
            Eflag.transform.localPosition = new Vector3(7f, 7, 405.4f);
        }else if (GameMgr.EnemyLocation == 8)
        {
            Eflag.transform.localPosition = new Vector3(94f, 7, 405.4f);
        }else if (GameMgr.EnemyLocation == 9)
        {
            Eflag.transform.localPosition = new Vector3(184f, 7, 405.4f);
        }else if (GameMgr.EnemyLocation == 10)
        {
            Eflag.transform.localPosition = new Vector3(269f, 7, 405.4f);
        }else if (GameMgr.EnemyLocation == 11)
        {
            Eflag.transform.localPosition = new Vector3(354f, 7, 405.4f);
        }else if (GameMgr.EnemyLocation == 12)
        {
            Eflag.transform.localPosition = new Vector3(444f, 7, 405.4f);
        }else if (GameMgr.EnemyLocation == 13)
        {
            Eflag.transform.localPosition = new Vector3(531f, 7, 405.4f);
        }
        
    }
}
