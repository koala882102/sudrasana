using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class a001 : MonoBehaviour
{
    public GameObject MyAttackAnOb;
    public bool IsDown;
    // Start is called before the first frame update
    void Start()
    {
        MyAttackAnOb = GameObject.Find("myAttackAn");
        MyAttackAnOb.SetActive(false);
        //Vector3 objectpos = MyAttackAnOb.transform.localPosition;
        //MyAttackAnOb.transform.localPosition = new Vector3(1944,objectpos.y, objectpos.z);
        //MyAttackAnOb.transform.position.x = 1944;
        IsDown = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(IsDown);
        if(IsDown){
            Invoke("MyAttackC", 2.0f);
            
        }
    }

    public void OnMouseDown()
    {
        //Invoke("MyAttack", 2.0f);
        //IsDown = true;
        
        if (Settlement.MyRound)
        {
            IsDown = true;
            //Debug.Log(IsDown);
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

    void MyAttackC(){
        Debug.Log("myattackopen");
        //MyAttackAnOb.transform.position.x = 0;
        MyAttackAnOb.SetActive(true);
        IsDown = false;
    }
}
