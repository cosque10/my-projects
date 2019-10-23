using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ScrollBarAffichage : MonoBehaviour
{
    public Image ScrollBarImage;
    private Scrollbar thisScrolbar;


    float currentTime = 2.0f;
    float timerMax = 0.5f;
    bool imageActive = false;

    private void OnEnable()
    {
        thisScrolbar = GetComponent<Scrollbar>();
    }

    public void scrollValueChange()
    {
        if(thisScrolbar.value < .99)
        {
            ScrollBarImage.enabled = true;
            currentTime = 0.0f;
        }   
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > timerMax && imageActive)
        {
            ScrollBarImage.enabled = false;
            imageActive = false;
        }
        if(currentTime<timerMax && !imageActive)
        {
            ScrollBarImage.enabled = true;
            imageActive = true;
        }
    }
}
