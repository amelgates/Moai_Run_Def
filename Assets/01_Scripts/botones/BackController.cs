using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackController : MonoBehaviour
{
    public void BackButton()
    {
        SceneManager.LoadScene("Menu");
    }

}
