using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerManager : MonoBehaviour
{
    [SerializeField] private AudioSource explosionPlayer; // Ship Explosion Player
    [SerializeField] private AudioClip explosionClip; // Ship Explosion Sound
    public HPBar HPBar;
    public GameObject explosion,fireEngine; // Explosion and Fire Effect
    public int playerMaxHP = 3; // Player MaxHP amount
    public int playerCurrentHP; // Player current HP
    public bool isDead = false; // Set player dead to false by default
    private void Start()
    {
        Time.timeScale = 1f; // set TimeScale to default speed when starting a game
        playerCurrentHP = playerMaxHP;
        HPBar.SetMaxHealth(playerMaxHP);
    }
    public void Update()
    {
        HPBar.SetCurrentHealth(playerCurrentHP);
        if (playerCurrentHP <= 0) // Disable Player Ship when HP reached 0
        { 
            explosionPlayer.clip = explosionClip;
            explosionPlayer.Play();
            isDead = true;
            explosion.SetActive(true); // Play Explosion Effect
            fireEngine.SetActive(false); // Disabled Fire Effect
            gameObject.SetActive(false);
            Time.timeScale = 0f; // Pause the game when Player ship destroyed
            SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
        }
        if(playerCurrentHP > playerMaxHP) // If PlayerHP is greater than MaxHp when Healed, Restore current HP back to MaxHP
        {
            playerCurrentHP = playerMaxHP;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy")) // Reduce Player Current HP by 1 when hit an enemy
        {
            playerCurrentHP--;
        }
    }
}
