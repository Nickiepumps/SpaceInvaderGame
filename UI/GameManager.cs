using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject inventory; // Inventory Canvas
    public PlayerManager playerManager; // Player HP Data
    private bool isPaused = false; // Game Pause boolean
    private void Update()
    {
        if(playerManager.isDead != true) // Can Toggle Inventory when Player is not dead
        {
            if (Input.GetKey(KeyCode.V))
            {
                inventory.SetActive(true);
            }
            else
            {
                inventory.SetActive(false); 
            }

            if (Input.GetKeyDown(KeyCode.Escape)) // Press Esc to pause to game
            {                
                if(isPaused != true) // Check if the is paused. If paused, set timeScale to 0 and show Pause scene.
                                     // If not, Set timeScale to 1 and close Pause scene.
                {
                    SceneManager.LoadScene("Paused", LoadSceneMode.Additive);
                    Time.timeScale = 0f;
                    isPaused = true;
                }
                else
                {
                    SceneManager.UnloadSceneAsync("Paused");
                    Time.timeScale = 1f;
                    isPaused = false;
                }
            }
        }
    }
}
