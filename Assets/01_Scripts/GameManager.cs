using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static GameManager Instance { get; private set; }//como acceder y modificar los datos de esta clase
    //esto es un single
    //es el unico que existe para que unity lo reconozca 

    public bool play;
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
        
    }
}
