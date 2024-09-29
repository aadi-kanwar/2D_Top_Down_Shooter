using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game");
        // SceneController.Instance.LoadScene("Game", Color.black, 1);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
