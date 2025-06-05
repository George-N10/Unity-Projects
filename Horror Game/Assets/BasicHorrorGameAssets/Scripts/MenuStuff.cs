using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuStuff : MonoBehaviour
{
    public string nextSceneName; // Name of the next scene to load
    public void RetryCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void RetryLevel1()
    {
        SceneManager.LoadScene("Level 1"); // Replace "Level1" with your first scene name
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu"); 
    }


    public void B_QuitGame()
    {
        Application.Quit();
    }
}
