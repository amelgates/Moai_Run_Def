using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static GameManager Instance { get; private set; }//como acceder y modificar los datos de esta clase
    //esto es un single
    //es el unico que existe para que unity lo reconozca 
<<<<<<< Updated upstream

    public bool play;
=======
    public int score = 0;
    public bool moving;
    public GameObject textDisplay;
    public GameObject textMenu;
    public GameObject textWarning;
    //play booleano para el game Over 
    public bool play = false;
    public GameObject data;
>>>>>>> Stashed changes
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
        
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        
=======
        //score se esta concatena a una cadena que es un espacio vacio
        //la otra forma es score.ToString()
        //textDisplay.GetComponent<TextMeshProUGUI>().text = score + "m";
        textDisplay.GetComponent<TextMeshProUGUI>().text = score.ToString();
        //concadenacion es diferente de la suma
        if(moving == false)
        {
            textWarning.SetActive(true);
            textWarning.GetComponent<TextMeshProUGUI>().text = "Necesitas moverte";
        }
        if(moving == true)
        {
            textWarning.SetActive(false);
        }

    }
    public void incrementScore()
    {
        score = score + 10;
    }
    public void incrementGameSpeed(float speed)
    {
        Time.timeScale = speed;
>>>>>>> Stashed changes
    }
}
