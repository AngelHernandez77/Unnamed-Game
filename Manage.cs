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
    //public Text nameText;

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

    private void updateCharacter(int selectedoption)
    {
        Character character = characterDB.GetCharacter(selectedoption);
        artworkSprite.sprite = character.characterSprite;
    }

    public void Load() 
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }

    public void Save()
    {
        PlayerPrefs.SetInt("selectedOption", selectedOption);
    }

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

    public void play() 
    {
        StartTransition();
        SceneManager.LoadScene("Game");
    }
}
