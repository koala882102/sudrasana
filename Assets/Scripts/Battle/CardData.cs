using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "newCardData", menuName = "CardData")]

public class CardData : ScriptableObject
{
    
    public enum CardType {attack,defense,move}
    public string cardID;
    public Sprite cardSprite;
    public CardType cardType;

    public int attack;
    public int goAheadAmount;
    public int backOffAmount;
    public int minCastDistanceLimit;
    public int maxCastDistanceLimit;
    [TextArea(3, 5)] public string cardDescription;

}
