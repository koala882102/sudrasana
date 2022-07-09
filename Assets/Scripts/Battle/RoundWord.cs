using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundWord : MonoBehaviour
{
    public GameObject w0;

    public GameObject w1;

    public GameObject w2;
    
    public GameObject w3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ButtonCImg1.round == 0)
        {
            w0.SetActive(true);
            w1.SetActive(false);
            w2.SetActive(false);
            w3.SetActive(false);
        }
        if (ButtonCImg1.round == 1)
        {
            w0.SetActive(false);
            w1.SetActive(true);
            w2.SetActive(false);
            w3.SetActive(false);
        }

        if (ButtonCImg1.round == 2)
        {
            w0.SetActive(false);
            w1.SetActive(false);
            w2.SetActive(true);
            w3.SetActive(false);
        }
        if (ButtonCImg1.round == 3)
        {
            w0.SetActive(false);
            w1.SetActive(false);
            w2.SetActive(false);
            w3.SetActive(true);
        }
    }
}
