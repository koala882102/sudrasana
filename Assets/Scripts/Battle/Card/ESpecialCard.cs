using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESpecialCard : MonoBehaviour
{
    public static int EspecialNum;
    
    public GameObject a0;

    public GameObject a1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ESpecial();
    }

    public void ESpecial()
    {
        if (EspecialNum == 0)
        {
            a0.SetActive(true);
            a1.SetActive(false);
        }
        if (EspecialNum == 1)
        {
            a0.SetActive(false);
            a1.SetActive(true);
        }
        if (EspecialNum == 2)
        {
            EspecialNum = 1;
        }
    }
}
