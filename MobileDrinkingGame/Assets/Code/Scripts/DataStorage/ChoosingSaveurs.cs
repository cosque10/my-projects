using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoosingSaveurs : MonoBehaviour
{
    private static ChoosingSaveurs instance;
    public static ChoosingSaveurs Instance
    {
        get { return instance; }
    }
    [HideInInspector]
    public  List<Toggle> Toggles = new List<Toggle>();

    private void OnEnable()
    {
        instance = this;

        for(int i = 0; i < transform.childCount; i++)
        {
            Toggles.Add(transform.GetChild(i).transform.GetChild(1).GetComponent<Toggle>());
        }
    }
}
