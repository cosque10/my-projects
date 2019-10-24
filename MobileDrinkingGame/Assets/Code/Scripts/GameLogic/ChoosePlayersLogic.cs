using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePlayersLogic : MonoBehaviour
{
    #region Skeleton
    private static ChoosePlayersLogic instance;
    public static ChoosePlayersLogic Instance
    {
        get { return instance; }
    }
    #endregion

    #region Enum
    [HideInInspector]
    public enum ChoosingPlayersMode 
    {
        /// <summary>
        /// turn by turn tour
        /// </summary>
        Clasic,
        /// <summary>
        /// Random player but everybody play on this turn
        /// </summary>
        RandomControlled,
        /// <summary>
        /// Totally Random
        /// </summary>
        Chaos
    }
   
    public ChoosingPlayersMode currentMode = ChoosingPlayersMode.Clasic;
    #endregion


    private int indexInTurn = 0;
    List<string> currentPlayersNames = new List<string>();
    private void OnEnable()
    {
        instance = this;
        indexInTurn = 0;
    }


    public string ChoosePlayerName()
    {
        string thisTurnPlayer = "";
        switch (currentMode)
        {
            case ChoosingPlayersMode.Clasic:
                if (indexInTurn == 0)
                {
                    currentPlayersNames.Clear();
                    for (int i = 0; i < GetPlayersNames.Instance.playerNames.Count; i++)
                    {
                        currentPlayersNames.Add(GetPlayersNames.Instance.playerNames[i]);
                    }
                    Debug.Log(currentPlayersNames.Count);
                }
                else if (indexInTurn == GetPlayersNames.Instance.playerNames.Count - 1)
                {

                    indexInTurn = -1;
                }


                thisTurnPlayer = currentPlayersNames[0];
                currentPlayersNames.Remove(currentPlayersNames[0]);
                indexInTurn++;
                return thisTurnPlayer;

                break;

            case ChoosingPlayersMode.RandomControlled:
                if (indexInTurn == 0)
                {
                    currentPlayersNames.Clear();
                    for (int i = 0; i < GetPlayersNames.Instance.playerNames.Count; i++)
                    {
                        currentPlayersNames.Add(GetPlayersNames.Instance.playerNames[i]);
                    }
                    Debug.Log(currentPlayersNames.Count);
                }
                else if (indexInTurn == GetPlayersNames.Instance.playerNames.Count - 1)
                {

                    indexInTurn = -1;
                }
                int myRandomNumber = Random.Range(0, currentPlayersNames.Count);
                thisTurnPlayer = currentPlayersNames[myRandomNumber];
                currentPlayersNames.Remove(currentPlayersNames[myRandomNumber]);
                indexInTurn++;
                return thisTurnPlayer;
                break;
            case ChoosingPlayersMode.Chaos:
                int myRandomChaos = Random.Range(0, GetPlayersNames.Instance.playerNames.Count);
                thisTurnPlayer = GetPlayersNames.Instance.playerNames[myRandomChaos];
                return thisTurnPlayer;
                break;
            default:
                return "Random";
                break;
        }
     
        
    }

    

}
