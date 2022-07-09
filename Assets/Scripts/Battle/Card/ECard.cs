using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ECard : MonoBehaviour
{
    public static bool a005e;
    public static bool a006e;
    public static bool a007e;
    public static bool a008e;
    public static bool specialcarde;

    public GameObject EC1;
    public GameObject EC2;
    public GameObject EC3;
    public GameObject EC4;
    public GameObject specialcardb;

    public static int a005eBuff;
    public static int a006eBuff;
    public static int a007eBuff;

    public static int specialcardBuff;

    public Settlement Settlement;
    // Start is called before the first frame update
    void Start()
    {
        a005e = true;
        a006e = true;
        a007e = true;
        a008e = true;
        specialcarde = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ECardEffect()
    {
        specialcardb.transform.localPosition = new Vector3(-2, -0.9f, 405.4f);
        EC1.transform.localPosition = new Vector3(-2, -0.9f, 405.4f);
        EC2.transform.localPosition = new Vector3(-2, -0.9f, 405.4f);
        EC3.transform.localPosition = new Vector3(-2, -0.9f, 405.4f);
        EC4.transform.localPosition = new Vector3(-2, -0.9f, 405.4f);
        if (Settlement.EnemyRound = true)
        {
            
            if (specialcarde && specialcardBuff == 0)
            {
                specialcardb.transform.localPosition = new Vector3(9, -2.34f, 405.4f);
                BuffText.B10TR = BuffText.B10TR + 2;
                BuffText.B10TN = BuffText.B10TN + 5;
                Settlement.b10.SetActive(true);
                specialcardBuff = 1;
                specialcarde = false;
            }
            else if (a008e)
            {
                specialcardBuff = 0;
                GameMgr.EnemyCardType = 2;
                EC4.transform.localPosition = new Vector3(9, -2.34f, 405.4f);
                BuffText.EB3TR = BuffText.EB3TR + 3;
                BuffText.EB3TN = BuffText.EB3TN + 10;
                Settlement.eb3.SetActive(true);
                BuffText.EB10TR = BuffText.EB10TR + 3;
                BuffText.EB10TN = BuffText.EB10TN + 2;
                Settlement.eb10.SetActive(true);
                a008e = false;
            }
            else if (a007e)
            {
                specialcardBuff = 0;
                GameMgr.EnemyCardType = 1;
                GameMgr.EAttackTimes = 1;
                EC3.transform.localPosition = new Vector3(9, -2.34f, 405.4f);
                if (GameMgr.Distance <= 6)
                {
                    GameMgr.EnemyRoundDamage = GameMgr.EnemyRoundDamage + 4;
                    a007eBuff = 1;
                }

                a007e = false;
            }
            else if (a006e)
            {
                specialcardBuff = 0;
                GameMgr.EnemyCardType = 1;
                GameMgr.EAttackTimes = 1;
                EC2.transform.localPosition = new Vector3(9, -2.34f, 405.4f);
                if (GameMgr.Distance <= 6)
                {
                    GameMgr.EnemyRoundDamage = GameMgr.EnemyRoundDamage + 4;
                    if (GameMgr.EnemyRoundDamage >= 1)
                    {
                        a006eBuff = 1; //雙方下回合脆弱5啟動
                    }
                }

                a006e = false;
            }
            else if (a005e)
            {
                specialcardBuff = 0;
                GameMgr.EnemyCardType = 1;
                GameMgr.EAttackTimes = 1;
                EC1.transform.localPosition = new Vector3(9, -2.34f, 405.4f);
                if (GameMgr.Distance <= 6)
                {
                    GameMgr.EnemyRoundDamage = GameMgr.EnemyRoundDamage + 4;
                    if (GameMgr.EnemyRoundDamage >= 1)
                    {
                        a005eBuff = 1; //雙方下回合虛弱5啟動
                    }
                }

                a005e = false;
            }

            
        }
    }
}
