using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MainLevel"); // Load MainLevel scene when click "Play"
    }
    public void Retry()
    {
        SceneManager.LoadScene("MainLevel"); // Reload MainLevel scene when click "Try Again"
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Load MainMenu scene when click "Main Menu"
    }
    public void Tutorial()
    {
        gameObject.SetActive(false);
        SceneManager.LoadScene("Tutorial", LoadSceneMode.Additive); // Load Tutorial scene overlay MainMenu scene when click "Tutorial"
    }
    public void Credit() // Load Credit scene when click "Credit"
    {
        SceneManager.LoadScene("Credit");
    }
    public void Exit() // Quit Game when click "Quit"
    {
        Application.Quit();
    }
    public void MainMenuOverlay()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single); // Load MainMenu scene overlay MainMenu scene when click "Main Menu"
    }
}
