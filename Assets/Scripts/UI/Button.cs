using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Button : MonoBehaviour
{
    public float revealDuration = 1f;
    public RectTransform rectTransform;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnClickTween(RectTransform rectTransform)
    {
        rectTransform.DOScale(rectTransform.localScale * 1.25f, revealDuration / 6f).SetLoops(2, LoopType.Yoyo);
    }
}
