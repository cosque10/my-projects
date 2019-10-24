using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="Nouvelle Saveur",menuName ="Saveur")]
public class Saveur : ScriptableObject
{
    
    public string saveurName;
    public string description;
    public string[] phrases;
    public Color backGroundColor;
}
