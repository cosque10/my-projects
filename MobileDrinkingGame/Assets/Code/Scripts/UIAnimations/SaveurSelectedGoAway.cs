using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveurSelectedGoAway : MonoBehaviour
{
    [HideInInspector]
    public Animator myAnimator;

    private void OnEnable()
    {
        myAnimator = GetComponent<Animator>();
    }

    public void ButtonGoAwayAnim()
    {
        myAnimator.SetTrigger("Unselected");
    }
    public void UnactiveObject()
    {
        KeepOnlySelectedSaveurs.Instance.containerVerticalLayoutON();
        this.gameObject.SetActive(false);
    }
}
