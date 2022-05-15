using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //inGaming es  la boleana  que se utiliza para el animator en muerte
    //keyPress almacena el valor de la letra presionada
    //countPress cuenta las veces que es precionada la tecla
    //prevkeyPress almacena el valor de la tecla presionada previamente
    public bool inGaming = true;
    public char keyPres;
    public int countPress = 0;
    public char prevKeyPress;
    public int countSpeed = 0;
   
    

    public Animator animator;
    private float gameSpeed = 1.0f;

    public char d { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        prevKeyPress = 'q';
         keyPres = 'x';
        animator = GetComponent<Animator>();
        //se llama para que espere ni bien inicia el juego
        StartCoroutine("controllerTimePress");

    }

// Update is called once per frame
void Update()
    {
        if(inGaming)
        controller();
        changeSpeed();

    }
    public void controller()
    {
        //detenemos la corutina antes de que se termine su tiempo
        //la corutina es como si nunca hiciera la tarea o lo evitamos
        //en este caso es game over
        //con start volvemos a iniciar el tiempo
        if (Input.GetKeyDown(KeyCode.A))
        {
            StopCoroutine("controllerTimePress");
            StartCoroutine("controllerTimePress");
            keyPres = 'a';
            animator.SetBool("IsMovRight", true);
            animator.SetBool("IsMovLeft", false);
            
            //print("a");
            if (keyPres == prevKeyPress)
            {
                countPress++;
                countSpeed = 0;
                //print(countPress);
            }
            else
            {
                prevKeyPress = keyPres;
                countSpeed++;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            StopCoroutine("controllerTimePress");
            StartCoroutine("controllerTimePress");
            keyPres = 'd';
            animator.SetBool("IsMovLeft", true);
            animator.SetBool("IsMovRight", false);
            //print("d");
            if (keyPres == prevKeyPress)
            {
                countPress++;
                countSpeed = 0;
                //print(countPress);
            }
            else
            {
                prevKeyPress = keyPres;
                countSpeed++;
            }
        }
       
        if(countPress>2)
        {
            //print("gameover");
            //Enumerator para terminar animaciones previas y darle play a la animacion de muerte
            if (Input.GetKeyDown(KeyCode.A))
            {
                animator.SetBool("FallLeft", true);
                animator.SetBool("FallRight", false);
                inGaming = false;
                //print("rueda");
                GameManager.Instance.gameOver();
            }

            ///adadadadadadadad pero 20 veces cambie a velocidad 2
            //cambia la animacion
            ///adadad pero 60 vecs a velocidad 3 que es la maxima
            // si pierdes
            // adadad para mueresasa
            // si dejas de apretar mueres  por lo que no se puede volver a la velociadad1
            if (Input.GetKeyDown(KeyCode.D))
            {
                animator.SetBool("FallRight", true);
                animator.SetBool("FallLeft", false);
                //print("secae");
                GameManager.Instance.gameOver();
            }
           
        }

    }
    public void changeSpeed()
    {
        
        if (GameManager.Instance.play)
        {
            if (countSpeed < 20)
            {

                GameManager.Instance.incrementGameSpeed(1.0f);
            }
            if (countSpeed >= 20)
            {
                GameManager.Instance.incrementGameSpeed(3.0f);
            }

            if (countSpeed >= 60)
            {
                GameManager.Instance.incrementGameSpeed(5.0f);
            }
        }
        else
        {
            GameManager.Instance.gameOver();
        }

        print(countSpeed);
        
    }
    IEnumerator controllerTimePress()
    {
        yield return new WaitForSeconds(2);
        GameManager.Instance.gameOver();
    }
}







