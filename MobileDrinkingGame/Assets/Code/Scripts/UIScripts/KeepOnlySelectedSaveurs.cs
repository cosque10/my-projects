using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KeepOnlySelectedSaveurs : MonoBehaviour
{
    public GameObject ButtonContainer;
    public void KeepSelectedSaveurs()
    {
        List<Toggle> myToggles = ChoosingSaveurs.Instance.Toggles;
        for (int i = 0; i < myToggles.Count; i++)
        {
            if (!myToggles[i].isOn)
            {
                myToggles[i].GetComponentInParent<SaveurSelectedGoAway>().ButtonGoAwayAnim();
            }
        }
        ButtonContainer.GetComponent<VerticalLayoutGroup>().enabled = true;
    }
}
