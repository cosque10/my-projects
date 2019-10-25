using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    #region Skeleton
    private static GameManager instance;
    public static GameManager Instance
    {
        get { return instance; }
    }
    #endregion
    #region Enum
    [HideInInspector]
    public enum GameState 
    {
        inMenu,
        inGame
    }
    public GameState currentGameState = GameState.inMenu;
    #endregion

    public GameObject GameOverCanvas;
    public GameObject inGameCanvas;
    public int MaximumClickPerGame;
    public TextMeshProUGUI inGameText;
    private void OnEnable()
    {
        instance = this;
    }
    public void FinishGame()
    {
        inGameCanvas.SetActive(false);
        GameOverCanvas.SetActive(true);
    }

}
