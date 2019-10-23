using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AddPlayers : MonoBehaviour
{
    public GameObject playersHolder;
    public GameObject playerNameInputField;
    [HideInInspector]
    public int inputCounter = 0;
    private float offsetMax;
    private static AddPlayers instance;
    public static AddPlayers Instance
    {
        get { return instance; }
    }
    private void OnEnable()
    {
        instance = this;
        offsetMax = 180 ;
        inputCounter = playersHolder.transform.childCount - 1;
    }
    public void AddBoutton()
    {
        RectTransform lastInputTransform = playersHolder.transform.GetChild(playersHolder.transform.childCount - 1).gameObject.GetComponent<RectTransform>();
        Vector3 positionToGo = new Vector3(lastInputTransform.position.x, lastInputTransform.position.y, lastInputTransform.position.z);
        GameObject newInputField = Instantiate(playerNameInputField, positionToGo, Quaternion.identity, playersHolder.transform);

        transform.SetParent(null, false);
        transform.SetParent(playersHolder.transform,false);
        transform.position = positionToGo;
        positionToGo = transform.localPosition;
        positionToGo.y -= 180;

        transform.localPosition = positionToGo;

        playersHolder.GetComponent<RectTransform>().offsetMax += new Vector2(0, offsetMax);


        inputCounter++;
    }
}
