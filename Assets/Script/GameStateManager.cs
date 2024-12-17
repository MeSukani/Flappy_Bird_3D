using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance;
    public bool isGameStarted = false;
    public bool isGameOver = false;
    public GameObject gameStartScreen;
    public GameObject gameOverScreen;
    public GameObject gameRestartScreen;
    private Animator animator;
    public GameObject gameScoreScreen;
    public GameObject gameScore;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

    }

    public void StartGame()
    {
        isGameStarted = true;
        isGameOver = false;
        Debug.Log("Game Started!");
    }

    public void GameOver()
    {
        isGameStarted = false;
        isGameOver = true;
        //Time.timeScale = 0;
        Debug.Log("Game Over!");
    }

    // Start is called before the first frame update
    void Start()
    {
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameStarted == true)
        {
            gameStartScreen.SetActive(false);
        }

        if (isGameOver == true)
        {
            gameScoreScreen.SetActive(true);
            gameScore.transform.position = new Vector3((gameScoreScreen.transform.position.x), (gameScoreScreen.transform.position.y - 250), 0);                        
            gameOverScreen.SetActive(true);
            gameRestartScreen.SetActive(true);
            Time.timeScale = 0;
            //if (animator != null)
            //{
            //    animator.SetBool("Fly", false);
            //}
        }
    }
}
