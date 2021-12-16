using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

//Database of all character sprites and names
//This is for playtest reference only. Characters are actually all premade and activated or deactivated with PlayerPrefs (int)
public class Character
{
    public string characterName;
    public Sprite characterSprite;
}
