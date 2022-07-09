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
            flag.transform.localPosition = new Vector3(9.29f, -9.2f, 405.4f);
            GameMgr.MyLocation = 4;
            //Debug.Log("按鈕按下重製距離");
            Eflag.transform.localPosition = new Vector3(14.1f, -9.2f, 405.4f);
            GameMgr.EnemyLocation = 10;
            Settlement.MyRound = false;
        }
    }

    public void SetFlag()
    {
        if (GameMgr.MyLocation == 1)
        {
            flag.transform.localPosition = new Vector3(6.83f, -9.2f, 405.4f);
        }else if (GameMgr.MyLocation == 2)
        {
            flag.transform.localPosition = new Vector3(7.67f, -9.2f, 405.4f);
        }else if (GameMgr.MyLocation == 3)
        {
            flag.transform.localPosition = new Vector3(8.46f, -9.2f, 405.4f);
        }else if (GameMgr.MyLocation == 4)
        {
            flag.transform.localPosition = new Vector3(9.31f, -9.2f, 405.4f);
        }else if (GameMgr.MyLocation == 5)
        {
            flag.transform.localPosition = new Vector3(10.07f, -9.2f, 405.4f);
        }else if (GameMgr.MyLocation == 6)
        {
            flag.transform.localPosition = new Vector3(10.92f, -9.2f, 405.4f);
        }else if (GameMgr.MyLocation == 7)
        {
            flag.transform.localPosition = new Vector3(11.71f, -9.2f, 405.4f);
        }else if (GameMgr.MyLocation == 8)
        {
            flag.transform.localPosition = new Vector3(12.5f, -9.2f, 405.4f);
        }else if (GameMgr.MyLocation == 9)
        {
            flag.transform.localPosition = new Vector3(13.32f, -9.2f, 405.4f);
        }else if (GameMgr.MyLocation == 10)
        {
            flag.transform.localPosition = new Vector3(14.14f, -9.2f, 405.4f);
        }else if (GameMgr.MyLocation == 11)
        {
            flag.transform.localPosition = new Vector3(14.99f, -9.2f, 405.4f);
        }else if (GameMgr.MyLocation == 12)
        {
            flag.transform.localPosition = new Vector3(15.75f, -9.2f, 405.4f);
        }else if (GameMgr.MyLocation == 13)
        {
            flag.transform.localPosition = new Vector3(16.6f, -9.2f, 405.4f);
        }
        
        if (GameMgr.EnemyLocation == 1)
        {
            Eflag.transform.localPosition = new Vector3(6.83f, -9.2f, 405.4f);
        }else if (GameMgr.EnemyLocation == 2)
        {
            Eflag.transform.localPosition = new Vector3(7.67f, -9.2f, 405.4f);
        }else if (GameMgr.EnemyLocation == 3)
        {
            Eflag.transform.localPosition = new Vector3(8.46f, -9.2f, 405.4f);
        }else if (GameMgr.EnemyLocation == 4)
        {
            Eflag.transform.localPosition = new Vector3(9.31f, -9.2f, 405.4f);
        }else if (GameMgr.EnemyLocation == 5)
        {
            Eflag.transform.localPosition = new Vector3(10.07f, -9.2f, 405.4f);
        }else if (GameMgr.EnemyLocation == 6)
        {
            Eflag.transform.localPosition = new Vector3(10.92f, -9.2f, 405.4f);
        }else if (GameMgr.EnemyLocation == 7)
        {
            Eflag.transform.localPosition = new Vector3(11.71f, -9.2f, 405.4f);
        }else if (GameMgr.EnemyLocation == 8)
        {
            Eflag.transform.localPosition = new Vector3(12.5f, -9.2f, 405.4f);
        }else if (GameMgr.EnemyLocation == 9)
        {
            Eflag.transform.localPosition = new Vector3(13.32f, -9.2f, 405.4f);
        }else if (GameMgr.EnemyLocation == 10)
        {
            Eflag.transform.localPosition = new Vector3(14.14f, -9.2f, 405.4f);
        }else if (GameMgr.EnemyLocation == 11)
        {
            Eflag.transform.localPosition = new Vector3(14.99f, -9.2f, 405.4f);
        }else if (GameMgr.EnemyLocation == 12)
        {
            Eflag.transform.localPosition = new Vector3(15.75f, -9.2f, 405.4f);
        }else if (GameMgr.EnemyLocation == 13)
        {
            Eflag.transform.localPosition = new Vector3(16.6f, -9.2f, 405.4f);
        }
        
    }
}
