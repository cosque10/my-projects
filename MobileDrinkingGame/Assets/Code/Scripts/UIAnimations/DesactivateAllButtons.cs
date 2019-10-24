using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesactivateAllButtons : MonoBehaviour
{

    //Saveurs Script
    public GameObject containerButtons;
    public GameObject buttonShakeThat;
    public GameObject nextCanvas;

    public void desactivateAll()
    {
      
        containerButtons.SetActive(false);
        
        buttonShakeThat.SetActive(false);
    }
    public void StartGame()
    {
        nextCanvas.SetActive(true);
        GameManager.Instance.currentGameState = GameManager.GameState.inGame;
        string currentName =  ChoosePlayersLogic.Instance.ChoosePlayerName();
        string currentPhrase = "will do this";
        GameManager.Instance.inGameText.text = currentName + " " + currentPhrase;
        gameObject.transform.parent.gameObject.SetActive(false);
    }
}
