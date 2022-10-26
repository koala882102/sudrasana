using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMgr : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip pressClip;
    public AudioClip checkCard;
    public AudioClip pressEnter;
    public void pressbutton()
    {
        audioSource.PlayOneShot(pressClip);
    }

    public void check()
    {
        audioSource.PlayOneShot(checkCard);
    }

    public void enter()
    {
        audioSource.PlayOneShot(pressEnter);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
