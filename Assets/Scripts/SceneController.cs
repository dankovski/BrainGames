using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController:MonoBehaviour
{

    public void quitGame()
    {
        Application.Quit();
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void playPegGame()
    {
        SceneManager.LoadScene(1);
    }

    public void playBlockPuzzle()
    {
        SceneManager.LoadScene(2);
    }

}
