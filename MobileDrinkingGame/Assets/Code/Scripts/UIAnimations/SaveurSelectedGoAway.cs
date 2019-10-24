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
        Debug.Log(name);
    }

    public void ButtonGoAwayAnim()
    {
        myAnimator.SetTrigger("Unselected");
    }
    public void UnactiveObject()
    {
        this.gameObject.SetActive(false);
    }
}
