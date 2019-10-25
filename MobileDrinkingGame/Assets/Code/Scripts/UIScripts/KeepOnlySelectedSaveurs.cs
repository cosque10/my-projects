using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KeepOnlySelectedSaveurs : MonoBehaviour
{

    [HideInInspector]
    public List<GameObject> SaveursRestantes = new List<GameObject>();
    private static  KeepOnlySelectedSaveurs instance;
    public static KeepOnlySelectedSaveurs Instance
    {
        get { return instance; }
    }



    public GameObject ButtonContainer;
    public GameObject Shaker;
    public int secondesBeforeShake = 1;



    private void OnEnable()
    {
        instance = this;
    }
    public void KeepSelectedSaveurs()
    {
        List<Toggle> myToggles = ChoosingSaveurs.Instance.Toggles;
        for (int i = 0; i < myToggles.Count; i++)
        {
            if(myToggles[i]  != null)
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
        ChoosePhrasesLogic.Instance.GetAllThePhrases(SaveursRestantes);
    }
    
    public void containerVerticalLayoutON()
    {
        ButtonContainer.GetComponent<VerticalLayoutGroup>().enabled = true;
        StartCoroutine(waitSomeTime(secondesBeforeShake));

    }

    IEnumerator waitSomeTime(int secondes)
    {
        for (int i = 0; i < secondes*60; i++)
        {
            yield return new WaitForEndOfFrame();
           
        }
        Shaker.GetComponent<Animator>().SetTrigger("Shake");
        
    }
}
