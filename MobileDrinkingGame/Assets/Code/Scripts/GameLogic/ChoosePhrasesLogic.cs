using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePhrasesLogic : MonoBehaviour
{
    #region Skeleton
    private static ChoosePhrasesLogic instance;
    public static ChoosePhrasesLogic Instance
    {
        get { return instance; }
    }
    #endregion

    public List<List<string>> phrasesCombinedFromAllSaveurs = new List<List<string>>();

    public List<Color> BGColor = new List<Color>();
    private void OnEnable()
    {
        instance = this;
    }

    public void GetAllThePhrases(List<GameObject> saveursRestantes)
    {
        for(int i = 0; i< saveursRestantes.Count; i++)
        {
            SaveurBoutton thisSaveur = saveursRestantes[i].GetComponent<SaveurBoutton>();
            List<string> myTemporaryList = new List<string>();
            BGColor.Add(thisSaveur.saveurBGColor);
            for(int x = 0; x < thisSaveur.saveurPhrases.Length; x++)
            {
                myTemporaryList.Add(thisSaveur.saveurPhrases[x]);
            }
            phrasesCombinedFromAllSaveurs.Add(myTemporaryList);           
        }
    }

    public string ChooseNextPhrase()
    {
        string nextPhrase;

        for(int i = 0; i < phrasesCombinedFromAllSaveurs.Count; i++)
        {
            if(phrasesCombinedFromAllSaveurs[i].Count == 0)
            {
                phrasesCombinedFromAllSaveurs.Remove(phrasesCombinedFromAllSaveurs[i]);
            }
        }

      
        int randomSaveur = Random.Range(0, phrasesCombinedFromAllSaveurs.Count);
        Debug.Log(randomSaveur + " Random Saveur" + "   " + phrasesCombinedFromAllSaveurs.Count);
        int randomPhrase = Random.Range(0, phrasesCombinedFromAllSaveurs[randomSaveur].Count);
        Debug.Log(randomPhrase +" Random Phrase" + "    " + phrasesCombinedFromAllSaveurs[randomSaveur].Count);



        if(phrasesCombinedFromAllSaveurs[randomSaveur][randomPhrase] != null)
        {
            nextPhrase = phrasesCombinedFromAllSaveurs[randomSaveur][randomPhrase];
            phrasesCombinedFromAllSaveurs[randomSaveur].Remove(phrasesCombinedFromAllSaveurs[randomSaveur][randomPhrase]);
        }
        else if (phrasesCombinedFromAllSaveurs.Count == 0)
        {
            // Boleen to end game
            nextPhrase = null;
        }
        else
        {
            // boleen to end game
            nextPhrase = null;
        }

        return nextPhrase; 
    }
    
}
