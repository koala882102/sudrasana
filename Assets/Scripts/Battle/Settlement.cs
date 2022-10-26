using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settlement : MonoBehaviour
{
    
    
    public static bool MyRound;
    public static bool EnemyRound;

    public static int RoundTimes;
    public static int MyThisHealth;

    public GameObject RoundEndAn;
    //public GameObject EnemySpecialAn;
    public GameObject GameOverAn;
    public GameObject MyDamageAn;

    public ECard ECard;
    public ResetFlag ResetFlag;

    public Text MyHealthNum;
    public Text EnemyHealthNum;
    public Text distence;
    
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject b4;
    public GameObject b5;
    public GameObject b6;
    public GameObject b7;
    public GameObject b8;
    public GameObject b9;
    public GameObject b10;
    public GameObject eb1;
    public GameObject eb2;
    public GameObject eb3;
    public GameObject eb4;
    public GameObject eb5;
    public GameObject eb6;
    public GameObject eb7;
    public GameObject eb8;
    public GameObject eb9;
    public GameObject eb10;
    // Start is called before the first frame update
    void Start()
    {
        MyRound = true;
        EnemyRound = true;
        GameMgr.MyLocation = 4;
        GameMgr.EnemyLocation = 10;
        GameMgr.MyHealth = 30;
        GameMgr.EnemyHealth = 40;
    }

    // Update is called once per frame
    void Update()
    {
        Round();
        Health();
    }

    public void Round()
    {
        
        if (RoundTimes == 0)
        {
            MyThisHealth = GameMgr.MyHealth;
            Debug.Log("當前血量"+MyThisHealth);
            if (BuffText.B10TR >= 1 || BuffText.EB10TR >= 1) //是否有灼燒
            {
                GameMgr.MyHealth = GameMgr.MyHealth - BuffText.B10TN;
                GameMgr.EnemyHealth = GameMgr.EnemyHealth - BuffText.EB10TN;
                if (BuffText.EB10TN >= 1 )
                {
                    ESpecialCard.EspecialNum++;
                }
            }

            if (BuffText.B8TR >= 1) //我方是否有麻痺
            {
                MyRound = false;
            }

            if (BuffText.EB8TR >= 1)
            {
                EnemyRound = false;
            }

            GameMgr.Distance = GameMgr.EnemyLocation - GameMgr.MyLocation; //檢定距離
            distence.text = GameMgr.Distance + "";

            ResetFlag.SetFlag(); //更新旗子

            if (EnemyRound)
            {
                ECard.ECardEffect();
            }

            RoundTimes = 1;
        }

        if (MyRound == false)
        {
            RoundEndAn.SetActive(true);
            Invoke("RoundEndAnend",2);
            
            
            
            if (GameMgr.MyCardType == 1) //我方出攻擊牌
            {
                GameMgr.EnemyHealth = GameMgr.EnemyHealth -
                                      (GameMgr.ThisRoundDamage + BuffText.B3TN + BuffText.EB2TN - BuffText.B4TN -
                                       BuffText.B1TN) * (GameMgr.MyAttackTimes - GameMgr.EDefenseTimes);
                if ((GameMgr.ThisRoundDamage + BuffText.B3TN + BuffText.EB2TN - BuffText.B4TN -
                    BuffText.B1TN) * (GameMgr.MyAttackTimes - GameMgr.EDefenseTimes) >= 1)
                {
                    ESpecialCard.EspecialNum++;
                    MyDamageAn.SetActive(true);
                    Invoke("MydamageAn",1);
                }

                GameMgr.ThisRoundDamage = 0;
            }

            if (ESpecialCard.EspecialNum == 1 && MyRound == false)
            {
                ECard.specialcarde = true;
                ESpecialCard.EspecialNum = 0;
            }
            if (ECard.specialcarde == true)
            {
                
                //EnemySpecialAn.SetActive(true);
                //Invoke("EspecialAn",3);
                
                
            }

            if (GameMgr.EnemyCardType == 1 && SpecialCard.SpecialCardBuff == 0) //敵方出攻擊牌
            {
                GameMgr.MyHealth = GameMgr.MyHealth -
                                   (GameMgr.EnemyRoundDamage +
                                    BuffText.EB3TN +
                                    BuffText.B2TN -
                                    BuffText.EB4TN -
                                    BuffText.EB1TN) * (GameMgr.EAttackTimes - GameMgr.MyDefenseTimes);
                Debug.Log("扣完的血量"+GameMgr.MyHealth);
                GameMgr.EnemyRoundDamage = 0;
            }
            
            

            if (SpecialCard.SpecialCardBuff >= 1)
            {
                SpecialCard.SpecialCardBuff++;
            }

            if (SpecialCard.SpecialCardBuff ==6)
            {
                SpecialCard.SpecialCardBuff = 0;
            }
            RoundTimes = 2;
        }
        //BUFF回合減少
        if (RoundTimes == 2 && MyRound == false)
        {
            BuffText.B1TR--;
            BuffText.B2TR--;
            BuffText.B3TR--;
            BuffText.B4TR--;
            BuffText.B5TR--;
            BuffText.B6TR--;
            BuffText.B7TR--;
            BuffText.B8TR--;
            BuffText.B9TR--;
            BuffText.B10TR--;
            BuffText.EB1TR--;
            BuffText.EB2TR--;
            BuffText.EB3TR--;
            BuffText.EB4TR--;
            BuffText.EB5TR--;
            BuffText.EB6TR--;
            BuffText.EB7TR--;
            BuffText.EB8TR--;
            BuffText.EB9TR--;
            BuffText.EB10TR--;
            if (BuffText.B1TR <= 0)
            {
                BuffText.B1TR = 0;
                BuffText.B1TN = 0;
                b1.SetActive(false);
            }
            if (BuffText.B2TR <= 0)
            {
                BuffText.B2TR = 0;
                BuffText.B2TN = 0;
                b2.SetActive(false);
            }
            if (BuffText.B3TR <= 0)
            {
                BuffText.B3TR = 0;
                BuffText.B3TN = 0;
                b3.SetActive(false);
            }
            if (BuffText.B4TR <= 0)
            {
                BuffText.B4TR = 0;
                BuffText.B4TN = 0;
                b4.SetActive(false);
            }
            if (BuffText.B5TR <= 0)
            {
                BuffText.B5TR = 0;
                BuffText.B5TN = 0;
                b5.SetActive(false);
            }
            if (BuffText.B6TR <= 0)
            {
                BuffText.B6TR = 0;
                BuffText.B6TN = 0;
                b6.SetActive(false);
            }
            if (BuffText.B7TR <= 0)
            {
                BuffText.B7TR = 0;
                BuffText.B7TN = 0;
                b7.SetActive(false);
            }
            if (BuffText.B8TR <= 0)
            {
                BuffText.B8TR = 0;
                BuffText.B8TN = 0;
                b8.SetActive(false);
            }
            if (BuffText.B9TR <= 0)
            {
                BuffText.B9TR = 0;
                BuffText.B9TN = 0;
                b9.SetActive(false);
            }
            if (BuffText.B10TR <= 0)
            {
                BuffText.B10TR = 0;
                BuffText.B10TN = 0;
                b10.SetActive(false);
            }
            if (BuffText.EB1TR <= 0)
            {
                BuffText.EB1TR = 0;
                BuffText.EB1TN = 0;
                eb1.SetActive(false);
            }
            if (BuffText.EB2TR <= 0)
            {
                BuffText.EB2TR = 0;
                BuffText.EB2TN = 0;
                eb2.SetActive(false);
            }
            if (BuffText.EB3TR <= 0)
            {
                BuffText.EB3TR = 0;
                BuffText.EB3TN = 0;
                eb3.SetActive(false);
            }
            if (BuffText.EB4TR <= 0)
            {
                BuffText.EB4TR = 0;
                BuffText.EB4TN = 0;
                eb4.SetActive(false);
            }
            if (BuffText.EB5TR <= 0)
            {
                BuffText.EB5TR = 0;
                BuffText.EB5TN = 0;
                eb5.SetActive(false);
            }
            if (BuffText.EB6TR <= 0)
            {
                BuffText.EB6TR = 0;
                BuffText.EB6TN = 0;
                eb6.SetActive(false);
            }
            if (BuffText.EB7TR <= 0)
            {
                BuffText.EB7TR = 0;
                BuffText.EB7TN = 0;
                eb7.SetActive(false);
            }
            if (BuffText.EB8TR <= 0)
            {
                BuffText.EB8TR = 0;
                BuffText.EB8TN = 0;
                eb8.SetActive(false);
            }
            if (BuffText.EB9TR <= 0)
            {
                BuffText.EB9TR = 0;
                BuffText.EB9TN = 0;
                eb9.SetActive(false);
            }
            if (BuffText.EB10TR <= 0)
            {
                BuffText.EB10TR = 0;
                BuffText.EB10TN = 0;
                eb10.SetActive(false);
            }

            RoundTimes = 2;
        }
        
        //卡牌後段效果
        if (RoundTimes == 2)
        {
            if (a002.a002Buff == 1)
            {
                a002.a002Buff = 2;
            }
            else if (a002.a002Buff == 2)
            {
                BuffText.B4TR = BuffText.B4TR + 1;
                BuffText.B4TN = BuffText.B4TN + 5;
                a002.a002Buff = 0;
                b4.SetActive(true);
            }

            if (a003.a003Buff == 1)
            {
                a003.a003Buff = 2;
            }
            else if (a003.a003Buff == 2)
            {
                BuffText.EB8TR = BuffText.EB8TR + 1;
                a003.a003Buff = 0;
                eb8.SetActive(true);
            }

            if (b006.b006Buff == 1)
            {
                b006.b006Buff = 2;
            }
            else if (b006.b006Buff == 2)
            {
                BuffText.B3TR = BuffText.B3TR + 1;
                BuffText.B3TN = BuffText.B3TN + 3;
                BuffText.EB3TR = BuffText.EB3TR + 1;
                BuffText.EB3TN = BuffText.EB3TN + 3;
                b006.b006Buff = 0;
                b3.SetActive(true);
                eb3.SetActive(true);
            }

            if (ECard.a005eBuff == 1)
            {
                ECard.a005eBuff = 2;
            }
            else if (ECard.a005eBuff == 2)
            {
                BuffText.B4TR = BuffText.B4TR + 1;
                BuffText.B4TN = BuffText.B4TN + 5;
                BuffText.EB4TR = BuffText.EB4TR + 1;
                BuffText.EB4TN = BuffText.EB4TN + 5;
                ECard.a005eBuff = 0;
                b4.SetActive(true);
                eb4.SetActive(true);
            }

            if (ECard.a006eBuff == 1)
            {
                ECard.a006eBuff = 2;
            }
            else if (ECard.a006eBuff == 2)
            {
                BuffText.B2TR = BuffText.B2TR + 1;
                BuffText.B2TN = BuffText.B2TN + 5;
                BuffText.EB2TR = BuffText.EB2TR + 1;
                BuffText.EB2TN = BuffText.EB2TN + 5;
                ECard.a006eBuff = 0;
                b2.SetActive(true);
                eb2.SetActive(true);
            }

            if (ECard.a007eBuff == 1)
            {
                if ((GameMgr.EnemyRoundDamage +
                     BuffText.EB3TN +
                     BuffText.B2TN -
                     BuffText.EB4TN -
                     BuffText.EB1TN) * (GameMgr.EAttackTimes - GameMgr.MyDefenseTimes) >= 1)
                {
                    GameMgr.EnemyHealth = GameMgr.EnemyHealth + 5;
                }
            }
            
            if (ESpecialCard.EspecialNum == 1 && MyRound == false)
            {
                ECard.specialcarde = true;
                ESpecialCard.EspecialNum = 0;
            }
            if (ECard.specialcarde == true)
            {
                
                //EnemySpecialAn.SetActive(true);
                //Invoke("EspecialAn",3);
                
                
            }

            RoundTimes = 3;
            MyRound = true;
            EnemyRound = true;
            GameMgr.RoundNum++;
        }

        if (RoundTimes == 3)
        {
            if (GameMgr.MyHealth <= 0)
            {
                GameOverAn.SetActive(true);
                Invoke("GameoverAn",2);
                Invoke("EndGame",2);
            }
            if(GameMgr.EnemyHealth <= 0)
            {
                GameOverAn.SetActive(true);
                Invoke("GameoverAn",2);
                Invoke("EndGame",2);
            }

            RoundTimes = 0;
        }
    }
    
    

    void RoundEndAnend()
    {
        RoundEndAn.SetActive(false);
    }

    void EspecialAn()
    {
        //EnemySpecialAn.SetActive(false);
    }

    void GameoverAn()
    {
        GameOverAn.SetActive(false);
    }

    void MydamageAn()
    {
        MyDamageAn.SetActive(false);
    }

    void Health()
    {
        MyHealthNum.text = GameMgr.MyHealth+"";
        EnemyHealthNum.text = GameMgr.EnemyHealth + "";
    }

    void EndGame()
    {
        Application.Quit();
    }
}
