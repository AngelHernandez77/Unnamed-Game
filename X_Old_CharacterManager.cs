using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;

public class X_Old_CharacterManager : MonoBehaviour
{
    //TEST END

    public Animator transition;

    public SpriteRenderer spriteRenderer;
    public List<Sprite> characterList = new List<Sprite>();

    private int chosenCharacter = 0;
    public GameObject playerCharacter;

    public void next()
    {
        chosenCharacter = chosenCharacter + 1;
        if (chosenCharacter == characterList.Count)
        {
            chosenCharacter = 0;
        }
        spriteRenderer.sprite = characterList[chosenCharacter];

        //Debug.Log(characterList[chosenCharacter]);
    }

    public void back()
    {
        chosenCharacter = chosenCharacter - 1;
        if (chosenCharacter < 0)
        {
            chosenCharacter = characterList.Count - 1;
        }
        spriteRenderer.sprite = characterList[chosenCharacter];
    }

    //TRANSITION

    int baseLevel = 2;

    public void StartTransition()
    {
        StartCoroutine(Load(baseLevel));
    }

    //Level index represents with a number the desired scene
    public IEnumerator Load(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("Game");
    }

    public void startGame()
    {
        //playerCharacter.
        
        //PrefabUtility.SaveAsPrefabAsset(playerCharacter, "Assets/Character Select/Chosen Character.prefab");
        StartTransition();

        SceneManager.LoadScene("Game");
    }
}

//VIDEO TUTORIAL --> https://www.youtube.com/watch?v=8ogyT842otg&ab_channel=diving_squid
