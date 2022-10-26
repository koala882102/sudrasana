using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TobattleAn : MonoBehaviour
{
    public GameObject tobattleob;
    // Start is called before the first frame update
    void Start()
    {
        tobattleob.SetActive(true);
        Invoke("disappearAn",1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void disappearAn()
    {
        tobattleob.SetActive(false);
    }
}
