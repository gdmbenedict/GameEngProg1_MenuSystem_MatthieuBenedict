using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static GameManager;

public class UIManager : MonoBehaviour
{
    public enum ScreenState
    {
        MainMenu,
        PauseMenu,
        GamePlayHUD,
        GameWinScreen,
        GameOverScreen,
        OptionsMenu
    }

    [Header("UI Screens")]

    public ScreenState screenState;

    public GameObject mainMenu;
    public GameObject pauseMenu;
    public GameObject gamePlayHUD;
    public GameObject gameWinScreen;
    public GameObject gameOverScreen;
    public GameObject OptionsMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSceen(ScreenState newScreenState)
    {
        //disables the current screen
        switch (screenState)
        {
            case ScreenState.MainMenu:
                mainMenu.SetActive(false);
                break;

            case ScreenState.PauseMenu:
                pauseMenu.SetActive(false);
                break;

            case ScreenState.GamePlayHUD:
                gamePlayHUD.SetActive(false);
                break;

            case ScreenState.GameWinScreen:
                gameWinScreen.SetActive(false);
                break;

            case ScreenState.GameOverScreen:
                gameOverScreen.SetActive(false);
                break;

            case ScreenState.OptionsMenu:
                OptionsMenu.SetActive(false);
                break;
        }

        //sets new screen state
        screenState = newScreenState;

        //enables the new screen
        switch (screenState)
        {
            case ScreenState.MainMenu:
                mainMenu.SetActive(true);
                break;

            case ScreenState.PauseMenu:
                pauseMenu.SetActive(true);
                break;

            case ScreenState.GamePlayHUD:
                gamePlayHUD.SetActive(true);
                break;

            case ScreenState.GameWinScreen:
                gameWinScreen.SetActive(true);
                break;

            case ScreenState.GameOverScreen:
                gameOverScreen.SetActive(true);
                break;

            case ScreenState.OptionsMenu:
                OptionsMenu.SetActive(true);
                break;

        }
    }

    
}
