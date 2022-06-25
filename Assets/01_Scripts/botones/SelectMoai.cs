using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectMoai : MonoBehaviour
{
    public void Moai()
    {
        SceneManager.LoadScene("Play");
    }
    public void TheRock()
    {
        SceneManager.LoadScene("TheRock");
    }
    public void MoaiChan()
    {
        SceneManager.LoadScene("MoaiChan");
    }
    public void WalterWhite()
    {
        SceneManager.LoadScene("WalterWhite");
    }
}
