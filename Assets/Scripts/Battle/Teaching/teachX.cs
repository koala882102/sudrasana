using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teachX : MonoBehaviour
{
    public GameObject page1;

    public GameObject page2;

    public GameObject page3;

    public GameObject page4;

    public GameObject Previous;

    public GameObject Next;

    public GameObject X;

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
        page1.SetActive(false);
        page2.SetActive(false);
        page3.SetActive(false);
        page4.SetActive(false);
        Previous.SetActive(false);
        Next.SetActive(false);
        X.SetActive(false);
        
        audiomgr.pressbutton();
    }
}
