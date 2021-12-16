using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Scratched content
public enum battleStates {START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{
    //Load Units
    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    //Units data
    Unit playerUnit;
    Unit enemyUnit;

    public battleStates newState;

    // Start is called before the first frame update
    void Start()
    {
        newState = battleStates.START;
        startBattle();
    }

    //Initiate battle
    void startBattle() 
    {
        GameObject playerObject = Instantiate(playerPrefab);
        GameObject enemyObject = Instantiate(enemyPrefab);
    }
}
