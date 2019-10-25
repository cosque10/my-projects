using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class GoToNextPhrase : MonoBehaviour,IPointerClickHandler
{
    private string currentName;
    private string currentPhrase;

    int clickCounter = 0;
    public void OnPointerClick(PointerEventData eventData)
    {
        if(clickCounter <= GameManager.Instance.MaximumClickPerGame)
        {
            currentName = ChoosePlayersLogic.Instance.ChoosePlayerName();
            currentPhrase = ChoosePhrasesLogic.Instance.ChooseNextPhrase();
            if(currentPhrase == null)
            {
                GameManager.Instance.FinishGame();
                clickCounter = GameManager.Instance.MaximumClickPerGame + 1;
                return;
            }

            GameManager.Instance.inGameText.text = currentName + " " + currentPhrase;
            clickCounter++;
        }
        else
        {
            GameManager.Instance.FinishGame();
        }
      


    }


   
}
