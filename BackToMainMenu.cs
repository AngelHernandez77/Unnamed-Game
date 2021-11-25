using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Temporary button to change the scene back to the main menu
    public void goBackToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
