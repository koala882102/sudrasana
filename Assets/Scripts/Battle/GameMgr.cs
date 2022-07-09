using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameMgr
{
    public static string ClickItemName = string.Empty;
    public static bool Live = false;

    public static int MyHealth;
    public static int EnemyHealth;
    public static int RoundNum; //回合數
    public static int ThisRoundDamage; //當前回合傷害
    public static int EnemyRoundDamage; //敵人的傷害
    public static int MyLocation; //我的位置
    public static int EnemyLocation; //敵人位置
    public static int Distance; //距離
    public static int MyCardType; //我方出牌種類 1:攻擊 2:防禦 3:位移
    public static int EnemyCardType; //敵方出牌種類
    public static int HaveBuff = BuffText.B1TR + BuffText.B2TR + BuffText.B3TR + BuffText.B4TR + BuffText.B5TR + BuffText.B6TR 
                                 + BuffText.B7TR + BuffText.B8TR + BuffText.B9TR + BuffText.B10TR; //是否有buff

    public static int EHaveBuff = BuffText.EB1TR + BuffText.EB2TR + BuffText.EB3TR + BuffText.EB4TR + BuffText.EB5TR +
                                  BuffText.EB6TR + BuffText.EB7TR + BuffText.EB8TR + BuffText.EB9TR + BuffText.EB10TR;

    public static int MyAttackTimes;
    public static int EAttackTimes;
    public static int MyDefenseTimes;
    public static int EDefenseTimes;
    public static int ID = 0;

    
}
