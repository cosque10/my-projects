using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KeepOnlySelectedSaveurs : MonoBehaviour
{

    List<GameObject> SaveursRestantes = new List<GameObject>();


    private static  KeepOnlySelectedSaveurs instance;
    public static KeepOnlySelectedSaveurs Instance
    {
        get { return instance; }
    }
    public GameObject ButtonContainer;

    private void OnEnable()
    {
        instance = this;
    }
    public void KeepSelectedSaveurs()
    {
        List<Toggle> myToggles = ChoosingSaveurs.Instance.Toggles;
        for (int i = 0; i < myToggles.Count; i++)
        {
            // IMpleter une erreur si il n'y a aucun mode choisi !!
            if (!myToggles[i].isOn)
            {
                myToggles[i].GetComponentInParent<SaveurSelectedGoAway>().ButtonGoAwayAnim();
            }
            else
            {
                SaveursRestantes.Add(myToggles[i].transform.parent.gameObject);
            }
        }
      
    }

    public void containerVerticalLayoutON()
    {
        ButtonContainer.GetComponent<VerticalLayoutGroup>().enabled = true;
    }
}
