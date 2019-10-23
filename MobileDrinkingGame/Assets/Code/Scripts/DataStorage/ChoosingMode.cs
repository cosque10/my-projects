using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosingMode : MonoBehaviour
{

    public int thisMode = 0;

    private static ChoosingMode instance;
    public static ChoosingMode Instance
    {
        get { return instance; }
    }
    private int modeChoose = 0;
    public int ModeChoose
    {
        get
        {
            return modeChoose;
        }
    } 

    private void OnEnable()
    {
        instance = this;
    }
    public void ChoseMode()
    {
        modeChoose = thisMode;
        Debug.Log("You choosed mode " + modeChoose.ToString() );
    }

}
