using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
[SerializeField] AudioSource musicSource;
public AudioClip background;

    private void Start() 
    {
          musicSource.clip = background;
          musicSource.Play();  
    }

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
    public void quitGame()
    {
        Application.Quit();
    }
}
