using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    //velocidad al game manager
    //public static GameManager instance;
    public static GameManager Instance { get; private set; }//como acceder y modificar los datos de esta clase
    //esto es un single
    //es el unico que existe para que unity lo reconozca 
    public int score = 0;
    public bool moving;
    public GameObject textDisplay;
    public GameObject textMenu;
    //play booleano para el game Over 
    public bool play = false;
    public GameObject data;
    private void Awake()
    {
        play = true;
        moving = false;
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
        //textDisplay.GetComponent<TextMeshProUGUI>().text = score + "m";
        textDisplay.GetComponent<TextMeshProUGUI>().text = score.ToString();
        //concadenacion es diferente de la suma

    }
    public void incrementScore()
    {
        score = score + 10;
    }
    public void incrementGameSpeed(float speed)
    {
        Time.timeScale = speed;
    }

    //public void isMoving()
    //{
    //    moving = true;
    //}
    //public void isNotMoving()
    //{
    //    Debug.Log("aca");
    //    moving = false;
    //}
    public void gameOver()
    {
        play = false;
        textMenu.SetActive(true); //oculta o muestra un objeto, en este caso el mensaje
        Time.timeScale = 0.0f; //para controlar la velocidad del juego
    }
    //se pone en los parentecis el parametro que va a recibir

   
}
