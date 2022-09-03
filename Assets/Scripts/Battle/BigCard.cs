using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BigCard : MonoBehaviour
{
    public int id;
    private bool isOver = false;
    public GameObject blackbackground;
    public GameObject c1, c2, c3, c4, c5, c6, c7, c8;
    public GameObject DCard;
    
    public void OnMouseEnter()
    {
        GameMgr.ID = id;
        isOver = true;
    }

    public void OnMouseExit()
    {
        if (GameMgr.ID == id)
        {
            GameMgr.ID = 0;
        }
        isOver = false;
    }
    
    private void Update()
    {
        //Debug.Log(this.gameObject.name+">"+isOver);
        //Debug.Log(GameMgr.ID);
        if (isOver)
        {
            blackbackground.SetActive(true);
            transform.localScale = new Vector3(1.22f,1.22f,1.22f);
            Vector3 objectpos = transform.localPosition;
            transform.localPosition = new Vector3(objectpos.x, -1f, objectpos.z);
            //Debug.Log(objectpos);
            transform.GetComponent<SpriteRenderer>().sortingOrder = 5;//設定layer
            //Debug.Log("滑鼠移到卡牌上");
            
        }
        else
        {
            transform.localScale = new Vector3(0.61f,0.61f,0.61f);
            transform.GetComponent<SpriteRenderer>().sortingOrder = 3; //設定layer
            Vector3 objectpos = transform.localPosition;
            transform.localPosition = new Vector3(objectpos.x, -2.155206f, objectpos.z);
            blackbackground.SetActive(false);
        }
        
        blackbackground.SetActive(GameMgr.ID != 0);
    }

    public void OnMouseDown()
    {
        if (Settlement.MyRound)
        {
            Vector3 CardPos = transform.position;
            transform.localPosition = new Vector3(-10, -2.155206f, 410.5752f);
            Debug.Log(CardPos);
            DCard.transform.position = CardPos;
            DCard.SetActive(true);
            Invoke("DestoryCard", 0.7f);
            if (c1.transform.position.x != -10f && c1.transform.position.x > CardPos.x)
            {
                c1.transform.Translate(-1.8f, 0f, 0f);
            }

            if (c2.transform.position.x != -10f && c2.transform.position.x > CardPos.x)
            {
                c2.transform.Translate(-1.8f, 0f, 0f);
            }

            if (c3.transform.position.x != -10f && c3.transform.position.x > CardPos.x)
            {
                c3.transform.Translate(-1.8f, 0f, 0f);
            }

            if (c4.transform.position.x != -10f && c4.transform.position.x > CardPos.x)
            {
                c4.transform.Translate(-1.8f, 0f, 0f);
            }

            if (c5.transform.position.x != -10f && c5.transform.position.x > CardPos.x)
            {
                c5.transform.Translate(-1.8f, 0f, 0f);
            }

            if (c6.transform.position.x != -10f && c6.transform.position.x > CardPos.x)
            {
                c6.transform.Translate(-1.8f, 0f, 0f);
            }

            if (c7.transform.position.x != -10f && c7.transform.position.x > CardPos.x)
            {
                c7.transform.Translate(-1.8f, 0f, 0f);
            }

            if (c8.transform.position.x != -10f && c8.transform.position.x > CardPos.x)
            {
                c8.transform.Translate(-1.8f, 0f, 0f);
            }
        }
    }
    

    public void DestoryCard()
    {
        DCard.SetActive(false);
    }
}
