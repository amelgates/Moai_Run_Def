using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissMoai : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene("MoaiChan");
    }
    public void MenuButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
