using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teachNext : MonoBehaviour
{
    public GameObject page1;

    public GameObject page2;

    public GameObject page3;

    public GameObject page4;

    public AudioMgr audiomgr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        audiomgr.pressbutton();
        if (teachPrevious.pageNum < 4)
        {
            teachPrevious.pageNum++;
            if (teachPrevious.pageNum == 1)
            {
                page1.SetActive(true);
                page2.SetActive(false);
                page3.SetActive(false);
                page4.SetActive(false);
            }else if (teachPrevious.pageNum == 2)
            {
                page1.SetActive(false);
                page2.SetActive(true);
                page3.SetActive(false);
                page4.SetActive(false);
            }else if (teachPrevious.pageNum == 3)
            {
                page1.SetActive(false);
                page2.SetActive(false);
                page3.SetActive(true);
                page4.SetActive(false);
            }else if (teachPrevious.pageNum == 4)
            {
                page1.SetActive(false);
                page2.SetActive(false);
                page3.SetActive(false);
                page4.SetActive(true);
            }
        }
        
    }
}
