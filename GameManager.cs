using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Animator transition;

    //Characters
    public GameObject Alex;
    public GameObject Leah;

    //Test
    public List<Sprite> characterList;

    void Start()
    {
        //Debug.Log(playerSprite);

        //Debug.Log(playerSprite.name);

        if (PlayerPrefs.GetInt("selectedOption") == 0)
        {
            activateAlex();
        }

        else if (PlayerPrefs.GetInt("selectedOption") == 1) 
        {
            activateLeah();
        }

        Debug.Log(Alex.active);

        //player.GetComponent<SpriteRenderer>().sprite = playerSprite;
    }

    //Activate one playable character an disable the rest
    void activateAlex() 
    {
        disableAllCharacters();
        Alex.SetActive(true);
    }

    void activateLeah()
    {
        disableAllCharacters();
        Leah.SetActive(true);
    }

    //Disable all characters (precaution measure)
    void disableAllCharacters() 
    {
        Alex.SetActive(false);
        Leah.SetActive(false);
    }
}
