using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayers : MonoBehaviour
{
    public GameObject playersHolder;


    public void AddBoutton()
    {
        for(int i = 0;i< playersHolder.transform.childCount; i++)
        {
            if (!playersHolder.transform.GetChild(i).gameObject.activeSelf)
            {
                playersHolder.transform.GetChild(i).gameObject.SetActive(true);
                return;
            }
        }
    }




}
