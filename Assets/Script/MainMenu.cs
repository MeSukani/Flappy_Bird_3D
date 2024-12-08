using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);        
    }

    public void eventDetected()
    {
        if (!GameStateManager.Instance.isGameStarted)
        {
            GameStateManager.Instance.StartGame();
        }
    }
    public void eventRestartDetected()
    {
        if (GameStateManager.Instance.isGameOver)
        {
            GameStateManager.Instance.gameOverScreen.SetActive(false);
            GameStateManager.Instance.gameRestartScreen.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
