using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manage : MonoBehaviour
{
    //Transition Animator
    public Animator transition;

    public CharacterDatabase characterDB;

    public SpriteRenderer artworkSprite;
    private int selectedOption = 0;

    void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }

        else 
        {
            Load();
        }

        updateCharacter(selectedOption);
    }

    //Next option to change character
    public void NextOption()
    {
        selectedOption++;

        if (selectedOption >= characterDB.characterCount)
        {
            selectedOption = 0;
        }

        updateCharacter(selectedOption);
        Save();
    }

    //Back button to change character
    public void BackOption()
    {
        selectedOption--;

        if (selectedOption < 0)
        {
            selectedOption = characterDB.characterCount - 1;
        }

        updateCharacter(selectedOption);
        Save();
    }

    //Just for reference in playtesting this virtually does nothing when built
    private void updateCharacter(int selectedoption)
    {
        Character character = characterDB.GetCharacter(selectedoption);
        artworkSprite.sprite = character.characterSprite;
    }

    //Load character
    public void Load() 
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

    //Save character
    public void Save()
    {
        PlayerPrefs.SetInt("selectedOption", selectedOption);
    }

    //Starts transition
    public void StartTransition()
    {
        StartCoroutine(LoadTransition());
    }

    //Level index represents with a number the desired scene
    public IEnumerator LoadTransition()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("Game");
    }

    //Play button
    public void play() 
    {
        StartTransition();
        SceneManager.LoadScene("Game");
    }
}
