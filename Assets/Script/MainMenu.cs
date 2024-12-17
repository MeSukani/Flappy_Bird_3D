using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    public AudioClip background;
    public AudioSource menuBtn;

    private void Start() 
    {
        musicSource.clip = background;
        musicSource.volume = 0.1f;
        musicSource.Play();
        GameStateManager.Instance.isGameStarted = false;
        GameStateManager.Instance.isGameOver = false;
    }

    public void PlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);        
    }

    public void eventDetected()
    {
        if (!GameStateManager.Instance.isGameStarted)
        {
            //musicSource.clip = background;
            musicSource.volume = 0.3f;
            //musicSource.Play();
            GameStateManager.Instance.StartGame();
        }
    }

    public void startDelay()
    {
        Debug.Log("delay executed");        
    }

    public void playMenuBtn()
    {
        menuBtn.Play();
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
