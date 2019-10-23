using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoosingSaveurs : MonoBehaviour
{
    private static ChoosingSaveurs instance;
    public static ChoosingSaveurs Instance;
    private static List<Button> Saveurs = new List<Button>();
    private static  List<Toggle> Toggles = new List<Toggle>();

    private void OnEnable()
    {
        Instance = this;
        for (int i = 0; i < this.transform.childCount; i++)
        {
            Saveurs.Add(this.transform.GetChild(i).GetComponent<Button>());
        }
        for(int i = 0; i < Saveurs.Count; i++)
        {
            Toggles.Add(Saveurs[i].transform.GetChild(1).GetComponent<Toggle>());
        }
    }
}
