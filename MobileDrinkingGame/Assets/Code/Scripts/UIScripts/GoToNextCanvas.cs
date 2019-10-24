using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToNextCanvas : MonoBehaviour
{
    public GameObject currentCanvas;
    public GameObject nextCanvas;

    public void goToNextCanvas()
    {
        nextCanvas.SetActive(true);
        currentCanvas.SetActive(false);
    }
}
