using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UiCrontrolller : MonoBehaviour
{
    public string namePlayer;
    public GameObject inputField;
    public GameObject textDisplay;
   //este script solo recibe valores
   public void saveName()
    {
        namePlayer = inputField.GetComponent<TMP_InputField>().text;
        textDisplay.GetComponent<TextMeshProUGUI>().text = namePlayer;
        GameObject dates = GameObject.FindWithTag("Noun");
        dates.GetComponent<Data>().namePlayer = namePlayer;
        SceneManager.LoadScene("Play");
    }

   

}
