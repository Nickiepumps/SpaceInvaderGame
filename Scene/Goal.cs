using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) // Add Win Scene overlay on current scene when player reached destination
    {
        if (collision.CompareTag("Finish"))
        {
            SceneManager.LoadScene("Win", LoadSceneMode.Additive);
        }
    }
}
