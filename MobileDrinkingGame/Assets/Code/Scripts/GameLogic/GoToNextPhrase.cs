using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class GoToNextPhrase : MonoBehaviour,IPointerClickHandler
{
    private string currentName = "";
    private string currentPhrase = "will do this";


    public void OnPointerClick(PointerEventData eventData)
    {
        currentName = ChoosePlayersLogic.Instance.ChoosePlayerName();
        GameManager.Instance.inGameText.text = currentName + " " + currentPhrase;
    }

   
}
