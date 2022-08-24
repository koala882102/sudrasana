using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCard : MonoBehaviour
{
    private int cardnum = 0;

    public GameObject a001ob;
    public GameObject a002ob;
    public GameObject a003ob;
    public GameObject a004ob;
    public GameObject a005ob;
    public GameObject a006ob;
    public GameObject a007ob;
    public GameObject a008ob;

    public GameObject cardTransform;

    private List<NewCardData> CardPool = new List<NewCardData>();
    // Start is called before the first frame update
    void Start()
    {
        CardPool.Add(new NewCardData() {NewCardNum = "a001"});
        CardPool.Add(new NewCardData() {NewCardNum = "a002"});
        CardPool.Add(new NewCardData() {NewCardNum = "a003"});
        CardPool.Add(new NewCardData() {NewCardNum = "a004"});
        CardPool.Add(new NewCardData() {NewCardNum = "a005"});
        CardPool.Add(new NewCardData() {NewCardNum = "a006"});
        CardPool.Add(new NewCardData() {NewCardNum = "a007"});
        CardPool.Add(new NewCardData() {NewCardNum = "a008"});
    }

    public void 抽卡()
    {
        
        int cardnum = Random.Range(0, 800);
        if (cardnum <= 99)
        {
            print("a001");
            GameObject go = Instantiate(a001ob,cardTransform.transform);
            go.transform.SetParent(cardTransform.transform);
        }else if(cardnum >= 100 && cardnum <= 199)
        {
            print("a002");
            GameObject go = Instantiate(a002ob,cardTransform.transform);
            go.transform.SetParent(cardTransform.transform);
        }else if (cardnum >= 200 && cardnum <= 299)
        {
            print("a003");
            GameObject go = Instantiate(a003ob,cardTransform.transform);
            go.transform.SetParent(cardTransform.transform);
        }else if (cardnum >= 300 && cardnum <= 399)
        {
            print("a004");
            GameObject go = Instantiate(a004ob,cardTransform.transform);
            go.transform.SetParent(cardTransform.transform);
        }else if (cardnum >= 400 && cardnum <= 499)
        {
            print("a005");
            GameObject go = Instantiate(a005ob,cardTransform.transform);
            go.transform.SetParent(cardTransform.transform);
        }else if (cardnum >= 500 && cardnum <= 599)
        {
            print("a006");
            GameObject go = Instantiate(a006ob,cardTransform.transform);
            go.transform.SetParent(cardTransform.transform);
        }else if (cardnum >= 600 && cardnum <= 699)
        {
            print("a007");
            GameObject go = Instantiate(a007ob,cardTransform.transform);
            go.transform.SetParent(cardTransform.transform);
        }else if (cardnum >= 700)
        {
            print("a008");
            GameObject go = Instantiate(a008ob,cardTransform.transform);
            go.transform.SetParent(cardTransform.transform);
        }
    }

    public class NewCardData
    {
        public string NewCardNum;
    }
}
