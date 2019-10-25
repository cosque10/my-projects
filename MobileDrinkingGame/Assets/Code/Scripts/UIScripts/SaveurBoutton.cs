using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SaveurBoutton : MonoBehaviour
{
    public Saveur mySaveur;
    public TextMeshProUGUI saveurName;
    public TextMeshProUGUI saveurDescription;
    [HideInInspector]
    public string[] saveurPhrases;
    [HideInInspector]
    public Color saveurBGColor;

    public string SaveurNameString;

    private void OnEnable()
    {
        SaveurNameString = mySaveur.saveurName;
        saveurName.text = SaveurNameString;
        saveurDescription.text = mySaveur.description;
        saveurPhrases = mySaveur.phrases;
        saveurBGColor = mySaveur.backGroundColor;
    }
}
