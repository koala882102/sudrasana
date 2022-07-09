using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class randomcard1 : MonoBehaviour
{
    int[] cardindex = new int[8];
    public GameObject[] card = new GameObject[8]; //物件
    private float[] cardlocation = new float[] {-1.7f,0.1f,1.9f,3.7f,5.5f,7.3f}; //位置
    
    List<int> card2 = new List<int>();
    

    // Start is called before the first frame update
    void Start()
    {
        for (int i= 0; i<cardindex.Length; i++)
        {
            cardindex[i] = i;
            
        }
        for (int j = 0; j < cardindex.Length; j++)
        {
            Debug.Log(cardindex[j]);
        }
        int num = Random.Range(2, 4);
        Debug.Log("num" + num);
        DrawCard(num);
    }

    void DrawCard(int n)
    {
        for (int i = 0; i < cardindex.Length; i++)
        {
            int ran = Random.Range(0, 6);
            int t = cardindex[ran];
            cardindex[ran] = cardindex[ran + 1];
            cardindex[ran + 1] = t;
        }
        for (int j = 0; j < n; j++)
        {
            card2.Add(cardindex[j]);
        }
        foreach (int k in card2)
        {
            Debug.Log(k);
        }
    }

    void SetCard(int l)
    {
        for (int k = 0; k < l; k++)
        {
            GameObject g = card[k];
            Vector3 cardpos = new Vector3(cardlocation[k], -2.155206f, 410.5752f);
            Instantiate(g);
        }
    }
       
   

    // Update is called once per frame
    
}
