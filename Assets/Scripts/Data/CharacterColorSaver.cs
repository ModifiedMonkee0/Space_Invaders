using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CharacterColorSaver : MonoBehaviour
{
    public Color renk;

   

    private void Start()
    {
        
        PlayerPrefs.DeleteAll();
    }

    public void ColorSave()
    {
        PlayerPrefs.SetFloat("RenkR", renk.r);
        PlayerPrefs.SetFloat("RenkG", renk.g);
        PlayerPrefs.SetFloat("RenkB", renk.b);
        PlayerPrefs.SetFloat("RenkA", renk.a);
        PlayerPrefs.Save();
        
        
    }

}
