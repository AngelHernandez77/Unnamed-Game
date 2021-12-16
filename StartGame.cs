using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    //On trigger collision to change scene
    public void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("Battle");
    }
}
