using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundButton : MonoBehaviour
{
    public AudioSource music;
    public GameObject off;
    private bool isOn;

    private void Start()
    {
       
    }

    public void SoundControl()
    {

        if(isOn==true)
        {
            SoundClose();
        }
        else
        {
            SoundOn();
        }
    }

    public void SoundClose()
    {
        off.SetActive(false);
        isOn = false;
        music.Play();
    }

    public void SoundOn()
    {
        off.SetActive(true);
        isOn = true;
        music.Stop();
    }



}
