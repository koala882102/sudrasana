using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teachNext : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (teachPrevious.pageNum < 4)
        {
            teachPrevious.pageNum++;
        }
        
    }
}
