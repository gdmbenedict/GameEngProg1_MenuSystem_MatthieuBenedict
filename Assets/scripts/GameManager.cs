using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UIManager;

public class GameManager : MonoBehaviour
{
    //gamestate enum
    public enum GameState
    {
        MainMenu,
        Gameplay,
        Paused,
        Options,
        GameOver,
        GameWin
    }

    [Header("Managers")]

    public LevelManager levelManager;
    public UIManager uiManager;

    [Header("Game States")]

    public GameState gameState;

    //sets default state for the game manager
    public void Awake()
    {
        //setting cursor
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        gameState = GameState.MainMenu;

        levelManager = FindObjectOfType<LevelManager>();
        uiManager = FindObjectOfType<UIManager>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeGameState(GameState newGameState)
    {
        //finished current game state, updates the game state and starts the new processes
        FinishGameState();
        gameState = newGameState;
        StartGameState();
    }

    private void FinishGameState()
    {
        //Finish current State
        switch (gameState)
        {
            case GameState.MainMenu:
                break;

            case GameState.Gameplay:
                break;

            case GameState.Paused:
                break;

            case GameState.Options:
                break;

            case GameState.GameOver:
                break;

            case GameState.GameWin:
                break;
        }
    }


    private void StartGameState()
    {
        //Start new Game State
        switch (gameState)
        {
            case GameState.MainMenu:
                uiManager.ChangeSceen(ScreenState.MainMenu);
                break;

            case GameState.Gameplay:
                uiManager.ChangeSceen(ScreenState.GamePlayHUD);
                break;

            case GameState.Paused:
                uiManager.ChangeSceen(ScreenState.PauseMenu);
                break;

            case GameState.Options:
                uiManager.ChangeSceen(ScreenState.OptionsMenu);
                break;

            case GameState.GameOver:
                uiManager.ChangeSceen(ScreenState.GameOverScreen);
                break;

            case GameState.GameWin:
                uiManager.ChangeSceen(ScreenState.GameWinScreen);
                break;
        }
    }



}
