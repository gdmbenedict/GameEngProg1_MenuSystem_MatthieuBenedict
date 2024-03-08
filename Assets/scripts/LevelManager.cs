using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool IsMainMenu()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name == "MainMenu")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void MoveToGameplay()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (!scene.name.StartsWith("Gameplay"))
        {
            SceneManager.LoadScene("Gameplay_Village1");
        }
    }

    public void MoveToEndScreen()
    {
        SceneManager.LoadScene("EndScene");
    }

    public void MoveToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
