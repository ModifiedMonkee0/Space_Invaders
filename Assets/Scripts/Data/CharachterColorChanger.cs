using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharachterColorChanger : MonoBehaviour
{
    public SpriteRenderer shipRenderer;
    void Start()
    {

        if (PlayerPrefs.HasKey("RenkR") && PlayerPrefs.HasKey("RenkG") && PlayerPrefs.HasKey("RenkB") && PlayerPrefs.HasKey("RenkA"))
        {
            // Kaydedilen rengi PlayerPrefs üzerinden alýyoruz
            float r = PlayerPrefs.GetFloat("RenkR");
            float g = PlayerPrefs.GetFloat("RenkG");
            float b = PlayerPrefs.GetFloat("RenkB");
            float a = PlayerPrefs.GetFloat("RenkA");

            Color kaydedilenRenk = new Color(r, g, b, a);
            shipRenderer.color = kaydedilenRenk;
        }
        else
        {
            shipRenderer.color = Color.white;
        }
        
    }

    
}
