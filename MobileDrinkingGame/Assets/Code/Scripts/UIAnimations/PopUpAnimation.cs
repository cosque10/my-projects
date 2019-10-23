using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpAnimation : MonoBehaviour
{
    public Animator PopUpAnimator;

    public void PopUpOn()
    {
        PopUpAnimator.SetTrigger("PopUpON");
    }

    public void PopUpOff()
    {
        PopUpAnimator.SetTrigger("PopUpOFF");
    }
}
