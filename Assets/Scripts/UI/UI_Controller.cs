using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class UI_Controller : MonoBehaviour
{
    public float revealDuration = 1f;
    public RectTransform uýController;
    public RectTransform meteor;
    public RectTransform textHeader;
    public RectTransform arrowSettings;
    public GameObject arrowSettings1;
    public RectTransform arrowCloth;
    public GameObject arrowCloth1;

    //cloth
    public RectTransform pinkShip;
    public RectTransform pinkSquare;
    public RectTransform redShip;
    public RectTransform redSquare;
    public RectTransform blueShip;
    public RectTransform blueSquare;


    private void Start()
    {
        meteor.DOAnchorPosX(-1118f, 5f).SetLoops(30);
        meteor.DOAnchorPosY(-706f, 5f).SetLoops(30);
        textHeader.DOScaleX( 1.3f, revealDuration).SetLoops(30,LoopType.Yoyo) ;
        textHeader.DOScaleY(1.3f, revealDuration).SetLoops(30, LoopType.Yoyo);
        arrowSettings.DOScaleX(1.3f, revealDuration).SetLoops(30, LoopType.Yoyo);
        arrowSettings.DOScaleY(1.3f, revealDuration).SetLoops(30, LoopType.Yoyo);
        arrowCloth.DOScaleX(1.3f, revealDuration).SetLoops(30, LoopType.Yoyo);
        arrowCloth.DOScaleY(1.3f, revealDuration).SetLoops(30, LoopType.Yoyo);



    }

    public void Settings()
    {
        uýController.DOAnchorPosX(-1400f, revealDuration);
        arrowSettings1.SetActive(true);
        
    }

    public void SettingsBack()
    {
        uýController.DOAnchorPosX(0f, revealDuration);
        arrowSettings1.SetActive(false);
    }

    public void Skin()
    {
        uýController.DOAnchorPosX(1400f, revealDuration);
        arrowCloth1.SetActive(true);
    }

    public void SkinBack()
    {
        uýController.DOAnchorPosX(0f, revealDuration);
        arrowCloth1.SetActive(false);
    }

    public void BlueScale()
    {
        pinkShip.DOScaleX(1f, revealDuration);
        pinkShip.DOScaleY(1f, revealDuration);
        pinkSquare.DOScaleX(1f, revealDuration);
        pinkSquare.DOScaleY(1f, revealDuration);

        redShip.DOScaleX(1f, revealDuration);
        redShip.DOScaleY(1f, revealDuration);
        redSquare.DOScaleX(1f, revealDuration);
        redSquare.DOScaleY(1f, revealDuration);

        blueShip.DOScaleX(1.3f, revealDuration);
        blueShip.DOScaleY(1.3f, revealDuration);
        blueSquare.DOScaleX(1.3f, revealDuration);
        blueSquare.DOScaleY(1.3f, revealDuration);

    }

    public void RedScale()
    {
        redShip.DOScaleX(1.3f, revealDuration);
        redShip.DOScaleY(1.3f, revealDuration);
        redSquare.DOScaleX(1.3f, revealDuration);
        redSquare.DOScaleY(1.3f, revealDuration);

        blueShip.DOScaleX(1f, revealDuration);
        blueShip.DOScaleY(1f, revealDuration);
        blueSquare.DOScaleX(1f, revealDuration);
        blueSquare.DOScaleY(1f, revealDuration);

        pinkShip.DOScaleX(1f, revealDuration);
        pinkShip.DOScaleY(1f, revealDuration);
        pinkSquare.DOScaleX(1f, revealDuration);
        pinkSquare.DOScaleY(1f, revealDuration);
    }

    public void PinkScale()
    {
        blueShip.DOScaleX(1f, revealDuration);
        blueShip.DOScaleY(1f, revealDuration);
        blueSquare.DOScaleX(1f, revealDuration);
        blueSquare.DOScaleY(1f, revealDuration);

        redShip.DOScaleX(1f, revealDuration);
        redShip.DOScaleY(1f, revealDuration);
        redSquare.DOScaleX(1f, revealDuration);
        redSquare.DOScaleY(1f, revealDuration);

        pinkShip.DOScaleX(1.3f, revealDuration);
        pinkShip.DOScaleY(1.3f, revealDuration);
        pinkSquare.DOScaleX(1.3f, revealDuration);
        pinkSquare.DOScaleY(1.3f, revealDuration);

    }
}
