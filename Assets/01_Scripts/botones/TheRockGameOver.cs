using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TheRockGameOver : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("TheRock");
    }
    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
