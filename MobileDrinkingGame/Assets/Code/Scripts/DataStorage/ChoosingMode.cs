using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosingMode : MonoBehaviour
{

    public ChoosePlayersLogic.ChoosingPlayersMode thisButtonMode = ChoosePlayersLogic.ChoosingPlayersMode.Clasic;


    public void ChoseMode()
    {
        ChoosePlayersLogic.Instance.currentMode = thisButtonMode;
    }

}
