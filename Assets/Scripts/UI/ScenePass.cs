using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class ScenePass : MonoBehaviour
{
    public GameObject src;
    public AudioSource musicSource;
    public AudioClip laser;
    public RectTransform mainUI;
    public float revealDuration = 1f;
    public void Contin()
    {
        mainUI.DOScale(Vector3.zero, revealDuration);
        src.SetActive(true);
        musicSource.clip = laser;
        musicSource.Play();

        StartCoroutine(Wait());
    }
    

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
       
        SceneManager.LoadScene("MainScene");
    }

   

}
