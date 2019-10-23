using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GetPlayersNames : MonoBehaviour
{
    public GameObject playerInputHolder;
    public List<string> playerNames = new List<string>();
    public void GetNames()
    {
        for (int i = 1; i <= playerInputHolder.transform.childCount - 2; i++)
        {

            if (playerInputHolder.transform.GetChild(i).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text.Length > 1)
            {
                playerNames.Add(playerInputHolder.transform.GetChild(i).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text);
            }
            
        }
        // Debug for
        for (int i = 0; i < playerNames.Count; i++)
        {
            Debug.Log(playerNames[i]);
        }
    }
    
}
