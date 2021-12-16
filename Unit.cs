using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    //Specific Stats of units
    public string unitName;
    public int unitLevel;

    public int unitDmg;
    public int unitDef;
    public int unitWis = 15;
    public int unitRes = 10;
    public int unitSpd;

    public int maxHp;
    public int currentHp;
}
