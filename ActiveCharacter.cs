using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveCharacter : MonoBehaviour
{
    public CharacterDatabase characterDB;

    public SpriteRenderer artworkSprite;

    private int selectedOption = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Load Selected Character if none has been selected set character int "selectedOption" to 0 (PlayerPref)
        //else load the saved Character

        Debug.Log("Selected option is" + PlayerPrefs.GetInt("selectedOption"));

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

    private void updateCharacter(int selectedOption)
    {
        //Load Character from the CharacterDatabase and its corresponding sprite
        Character character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
    }

    private void Load()
    {
        //Load saved character (PlayerPrefs)
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }
}
