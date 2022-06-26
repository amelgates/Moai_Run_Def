using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectMoai : MonoBehaviour
{
    public void MoaiScene()
    {
        SceneManager.LoadScene("Play");
    }
    public void TheRockScene()
    {
        SceneManager.LoadScene("TheRock");
    }
    public void MoaiChanScene()
    {
        SceneManager.LoadScene("MoaiChan");
    }
    public void WalterWhiteScene()
    {
        SceneManager.LoadScene("WalterWhite");
    }
}
