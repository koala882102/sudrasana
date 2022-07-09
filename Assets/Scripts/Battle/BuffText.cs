using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuffText : MonoBehaviour
{
    public Text B1T;
    public Text B2T;
    public Text B3T;
    public Text B4T;
    public Text B5T;
    public Text B6T;
    public Text B7T;
    public Text B8T;
    public Text B9T;
    public Text B10T;
    public Text EB1T;
    public Text EB2T;
    public Text EB3T;
    public Text EB4T;
    public Text EB5T;
    public Text EB6T;
    public Text EB7T;
    public Text EB8T;
    public Text EB9T;
    public Text EB10T;

    public static int B1TR;
    public static int B2TR;
    public static int B3TR;
    public static int B4TR;
    public static int B5TR;
    public static int B6TR;
    public static int B7TR;
    public static int B8TR;
    public static int B9TR;
    public static int B10TR;
    public static int EB1TR;
    public static int EB2TR;
    public static int EB3TR;
    public static int EB4TR;
    public static int EB5TR;
    public static int EB6TR;
    public static int EB7TR;
    public static int EB8TR;
    public static int EB9TR;
    public static int EB10TR;

    public static int B1TN;
    public static int B2TN;
    public static int B3TN;
    public static int B4TN;
    public static int B5TN;
    public static int B6TN;
    public static int B7TN;
    public static int B8TN;
    public static int B9TN;
    public static int B10TN;
    public static int EB1TN;
    public static int EB2TN;
    public static int EB3TN;
    public static int EB4TN;
    public static int EB5TN;
    public static int EB6TN;
    public static int EB7TN;
    public static int EB8TN;
    public static int EB9TN;
    public static int EB10TN;
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        SetCountText();
    }

    public void SetCountText()
    {
        B1T.text = B1TR + "回合內，受到傷害減少" + B1TN;
        B2T.text = B2TR + "回合內，受到傷害增加" + B2TN;
        B3T.text = B3TR + "回合內，造成傷害增加" + B3TN;
        B4T.text = B4TR + "回合內，造成傷害減少" + B4TN;
        B5T.text = B5TR + "回合內，移動距離增加" + B5TN;
        B6T.text = B6TR + "回合內，移動距離減少" + B6TN;
        B7T.text = B7TR + "回合內，不可移動";
        B8T.text = B8TR + "回合內，不可出牌";
        B9T.text = B9TR + "回合內，不可抽牌";
        B10T.text = B10TR + "回合內，受到傷害" + B10TN;
        
        EB1T.text = EB1TR + "回合內，受到傷害減少" + EB1TN;
        EB2T.text = EB2TR + "回合內，受到傷害增加" + EB2TN;
        EB3T.text = EB3TR + "回合內，造成傷害增加" + EB3TN;
        EB4T.text = EB4TR + "回合內，造成傷害減少" + EB4TN;
        EB5T.text = EB5TR + "回合內，移動距離增加" + EB5TN;
        EB6T.text = EB6TR + "回合內，移動距離減少" + EB6TN;
        EB7T.text = EB7TR + "回合內，不可移動";
        EB8T.text = EB8TR + "回合內，不可出牌";
        EB9T.text = EB9TR + "回合內，不可抽牌";
        EB10T.text = EB10TR + "回合內，受到傷害" + EB10TN;
        
    }
}
