using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WalterWhiteGameOver : MonoBehaviour
{  
    public void RestartButton()
    {
        SceneManager.LoadScene("WalterWhite");
    }
    public void ExitButton()
    {
        SceneManager.LoadScene("Menu");
    }
}
