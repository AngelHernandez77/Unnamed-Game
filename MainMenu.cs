using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Animator transition;
    
    //Default Scene triggered when play button is pressed
    int BaseLevel = 1;

    //Play button (will load the character selection scene)
    public void Play ()
    {
        StartTransition();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Exit Button
    public void Exit()
    {
        Application.Quit();
    }

    public void Credits() 
    {
        SceneManager.LoadScene("Credits");
    }

    //Initiate Transition
    public void StartTransition()
    {
        StartCoroutine(Load(BaseLevel));
    }

    //Level index represents with a number the desired scene
    public IEnumerator Load(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(levelIndex);
    }
}
