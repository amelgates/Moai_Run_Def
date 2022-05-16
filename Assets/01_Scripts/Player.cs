using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //inGaming es  la booleana  que se utiliza para el animator en muerte
    //keyPress almacena el valor de la letra presionada
    //countPress cuenta las veces que es presionada la tecla
    //prevkeyPress almacena el valor de la tecla presionada previamente
    public bool inGaming = true;
    public char keyPres;
    public int countPress = 0;
    public char prevKeyPress;
    

    public Animator animator;

    public char d { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        prevKeyPress = 'q';
         keyPres = 'x';
        animator = GetComponent<Animator>();

     }

// Update is called once per frame
void Update()
    {
        if(inGaming)
        controller();


    }
    public void controller()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            
            keyPres = 'a';
            animator.SetBool("IsMovRight", false);
            animator.SetBool("IsMovLeft", true);
            
            print("a");
            if (keyPres == prevKeyPress)
            {
                countPress++;
                print(countPress);
            }
            else
            {
                prevKeyPress = keyPres;
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            keyPres = 'd';
            animator.SetBool("IsMovLeft", false);
            animator.SetBool("IsMovRight", true);
            print("d");
            if (keyPres == prevKeyPress)
            {
                countPress++;
                print(countPress);
            }
            else
            {
                prevKeyPress = keyPres;
            }
        }
       
        if(countPress>2)
        {
            print("gameover");
            //Enumerator para terminar animaciones previas y darle play a la animacion de muerte
            if (Input.GetKeyDown(KeyCode.A))
            {
                animator.SetBool("FallLeft", true);
                animator.SetBool("FallRight", false);
                inGaming = false;
                print("rueda");
            }


            if (Input.GetKeyDown(KeyCode.D))
            {
                animator.SetBool("FallRight", true);
                animator.SetBool("FallLeft", false);
                print("secae");

            }
            
        }

    }

}







