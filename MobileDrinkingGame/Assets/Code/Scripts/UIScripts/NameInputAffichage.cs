using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class NameInputAffichage : MonoBehaviour
{
    private TextMeshProUGUI StartText;
    private void OnEnable()
    {
        StartText = transform.GetChild(0).GetChild(1).GetComponent<TextMeshProUGUI>();
        if (StartText != null)
        {
            StartText.text = "Joueur " + (AddPlayers.Instance.inputCounter +1).ToString();
        }
       
    }
}
