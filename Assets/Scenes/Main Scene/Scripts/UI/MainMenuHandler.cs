using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MainMenuHandler : MonoBehaviour
{
    [SerializeField] private GameObject _pauseMenu;
    //[SerializeField] private GameObject _pasueButton;
    public bool paused = false;


    void Awake()
    {
        MainGameManager.OnGameStateChanged += GameManagerOnGameStateChanged;
    }

    // Its good practice to unsubscribe from events
    void OnDestroy()
    {
        MainGameManager.OnGameStateChanged -= GameManagerOnGameStateChanged;
    }

    private void GameManagerOnGameStateChanged(GameState state)
    {
       if(state == GameState.Paused)
        {
            Pause();
        }

        if (state == GameState.Play)
        {
            Resume();
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }



   public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    } 

    public void HandlePause()
    {
      MainGameManager.Instance.UpdateGameState(GameState.Paused);
    }

    public void Resume()
    {
        paused = false;
        Time.timeScale = 1f;
        _pauseMenu.SetActive(false);
       
    }

    public void Pause()
    {
        paused = true;
        Time.timeScale = 0f;
        _pauseMenu.SetActive(true);
    }
}
