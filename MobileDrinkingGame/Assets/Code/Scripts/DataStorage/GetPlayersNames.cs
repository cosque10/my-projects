using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GetPlayersNames : MonoBehaviour
{
    private static  GetPlayersNames instance;
    public static GetPlayersNames Instance
    {
        get { return instance; }
    }
    public GameObject playerInputHolder;
    public GameObject PopUpAdvertisment;
    [HideInInspector]
    public List<string> playerNames = new List<string>();
    private void OnEnable()
    {
        instance = this;
    }
    public void GetNames()
    {
        for (int i = 1; i <= playerInputHolder.transform.childCount - 2; i++)
        {

            if (playerInputHolder.transform.GetChild(i).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text.Length > 1)
            {
                playerNames.Add(playerInputHolder.transform.GetChild(i).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text);
            }
            
        }
        if(playerNames.Count < 2)
        {
            PopUpAdvertisment.SetActive(true);
        }
        else
        {
            GetComponent<GoToNextCanvas>().goToNextCanvas();
        }
        
    }
    
}
