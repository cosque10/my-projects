using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePhrasesLogic : MonoBehaviour
{
 
    public void dothisforme()
    {
        for(int i = 0; i < KeepOnlySelectedSaveurs.Instance.SaveursRestantes.Count; i++)
        {
            Debug.Log(KeepOnlySelectedSaveurs.Instance.SaveursRestantes[i]);
        }
    }
}
