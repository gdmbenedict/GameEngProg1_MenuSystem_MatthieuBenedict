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

    }


    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
        uiManager = FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateState();
    }

    public void ChangeGameState(GameState newGameState)
    {
        //Finish current State
        switch (gameState)
        {
            case GameState.MainMenu:
                ExitMainMenuState();
                break;

            case GameState.Gameplay:
                ExitGamePlayState();
                break;

            case GameState.Paused:
                ExitPausedState();
                break;

            case GameState.Options:
                ExitOptionsState();
                break;

            case GameState.GameOver:
                ExitGameOverState();
                break;

            case GameState.GameWin:
                ExitGameWinState();
                break;
        }

        //Start next state
        switch (newGameState)
        {
            case GameState.MainMenu:
                EnterMainMenuState();
                break;

            case GameState.Gameplay:
                EnterGamePlayState();
                break;

            case GameState.Paused:
                EnterPausedState();
                break;

            case GameState.Options:
                EnterOptionsState();
                break;

            case GameState.GameOver:
                EnterGameOverState();
                break;

            case GameState.GameWin:
                EnterGameWinState();
                break;
        }

        gameState = newGameState;
    }

    private void UpdateState()
    {
        switch (gameState)
        {
            case GameState.MainMenu:
                UpdateMainMenuState();
                break;

            case GameState.Gameplay:
                UpdateGamePlayState();
                break;

            case GameState.Paused:
                UpdatePausedState();
                break;

            case GameState.Options:
                UpdateOptionsState();
                break;

            case GameState.GameOver:
                UpdateGameOverState();
                break;

            case GameState.GameWin:
                UpdateGameWinState();
                break;
        }
    }

    
    private void EnterMainMenuState()
    {

    }

    private void UpdateMainMenuState()
    {

    }

    private void ExitMainMenuState()
    {

    }

    private void EnterGamePlayState()
    {

    }

    private void UpdateGamePlayState()
    {

    }

    private void ExitGamePlayState()
    {

    }

    private void EnterPausedState()
    {

    }

    private void UpdatePausedState()
    {

    }

    private void ExitPausedState()
    {

    }

    private void EnterOptionsState()
    {

    }

    private void UpdateOptionsState()
    {

    }

    private void ExitOptionsState()
    {

    }

    private void EnterGameOverState()
    {

    }

    private void UpdateGameOverState()
    {

    }

    private void ExitGameOverState()
    {

    }

    private void EnterGameWinState()
    {

    }

    private void UpdateGameWinState()
    {

    }

    private void ExitGameWinState()
    {

    }

    //Button Functions
    public void QuitGame()
    {
        Application.Quit();
    }

    //Options Button
    public void OptionsButton()
    {
        ChangeGameState(GameState.Options);
    }

    //Back Button (also used for escape key functionality
    public void BackButton()
    {
        switch (gameState)
        {
            case GameState.MainMenu:
                QuitGame();
                break;

            case GameState.Gameplay:
                ChangeGameState(GameState.Paused);
                break;

            case GameState.Paused:
                ChangeGameState(GameState.Gameplay);
                break;

            case GameState.GameOver:
                ChangeGameState(GameState.MainMenu);
                break;

            case GameState.GameWin:
                ChangeGameState(GameState.MainMenu);
                break;

            case GameState.Options:

                if (levelManager.IsMainMenu())
                {
                    ChangeGameState(GameState.MainMenu);
                }
                else
                {
                    ChangeGameState(GameState.Paused);
                }

                break;
        }
    }

}
