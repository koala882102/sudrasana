using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPTmgr : MonoBehaviour
{
    public Button darwCard;

    public GameObject cardPrefab; //source 
    public GameObject cardPool; //target
    
    private float[] cardlocation = new float[] {7.3f,5.5f,3.7f,1.9f,0.1f,-1.7f}; //位置
    
    // Start is called before the first frame update
    void Start()
    {
        darwCard.onClick.AddListener(OnGetCard);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGetCard()
    {
        GameObject temp = Instantiate(cardPrefab);

        // parent
        temp.transform.parent = cardPool.transform;

        //reset
        temp.transform.localScale = Vector3.one;
        //temp.transform.localPosition = 
        // temp.GetCom...  //change sprite ... etc ...[ with Handler]
    }
}