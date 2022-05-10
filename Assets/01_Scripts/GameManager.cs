using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //velocidad al game manager
    public static GameManager instance;
    public static GameManager Instance { get; private set; }//como acceder y modificar los datos de esta clase
    //esto es un single
    //es el unico que existe para que unity lo reconozca 
    public int score = 0;
    public GameObject textDisplay;

    public bool play;
    public GameObject data;
    private void Awake()
    {
        // Si existe una instancia, se destruye.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        data = GameObject.FindWithTag("Noun");
    }

    // Update is called once per frame
    void Update()
    {
        //score se esta concatena a una cadena que es un espacio vacio
        //la otra forma es score.ToString()
        //textDisplay.GetComponent<TextMeshProUGUI>().text = score + "";
        textDisplay.GetComponent<TextMeshProUGUI>().text = score.ToString();
        //concadenacion diferente de la suma

    }
    public void incrementScore()
    {
        score = score + 10;
    }
}
