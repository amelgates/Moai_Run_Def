using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("Play");
        //Time.timeScale = 1.0f;
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("Menu");
    }
}

