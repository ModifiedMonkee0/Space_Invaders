using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class RestartScene : MonoBehaviour
{
    public RectTransform restart;
    public RectTransform mainMenu;
    private float duration=1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Retry()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainScene");
       
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartScene");
    }

    public void NextLevel2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level2");
       
    }
    public void NextLevel3()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level3");

    }



}
