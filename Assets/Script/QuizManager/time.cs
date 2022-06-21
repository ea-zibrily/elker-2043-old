using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DentedPixel;

public class time : MonoBehaviour
{
    public GameObject bar;
    public int timee;
    public bool timeout;

    public quizmanager timequiz;

    private void Awake()
    {
        timeout = false;
    }

    private void Update()
    {
        animatedBar();
        if(timeout)
        {
            timequiz.wrong();
            bar.SetActive(false);
        }
    }

    void animatedBar()
    {
        LeanTween.scaleX(bar, 1, timee);
        timeout = true;
    }
}
