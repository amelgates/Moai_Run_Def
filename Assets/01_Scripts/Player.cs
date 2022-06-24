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
    //public AudioClip normalSong;
    //public AudioClip speedSong1;
    //public AudioClip speedSong2;
    public GameObject arrowBar;
    public Animator animator;

    float actionTimer;
    [SerializeField] float losingTimer = 1.5f;
    [SerializeField] float stoppingTimer = 0.8f;

    private AudioSource font;


    //Coroutine timePress;
    //private float gameSpeed = 1.0f;
    // public char d { get; private set; }
    // Start is called before the first frame update
    void Start()
    {

        prevKeyPress = 'q';
        keyPres = 'x';
        animator = GetComponent<Animator>();
        //se llama para que espere ni bien inicia el juego
        //timePress = StartCoroutine("controllerTimePress");
    }

    // Update is called once per frame
    void Update()
    {
        if(inGaming)
        controller();
        changeSpeed();
        noActionTimer();
        //font = GetComponent<AudioSource>();
    }

    void noActionTimer() 
    {
        actionTimer += Time.deltaTime;
        if (actionTimer > losingTimer) 
        {
            StartCoroutine(waitGameOver());
            animator.SetBool("FallLeft", true);
            animator.SetBool("FallRight", true);
        }
        else if (actionTimer > stoppingTimer) 
        {
            GameManager.Instance.moving = false;
        }
    }

    public void controller()
    {
        //detenemos la corutina antes de que se termine su tiempo
        //la corutina es como si nunca hiciera la tarea o lo evitamos
        //en este caso es game over
        //con start volvemos a iniciar el tiempo
        if (Input.GetKeyDown(KeyCode.A))
        {
            //StopCoroutine(timePress);
            //timePress = StartCoroutine("controllerTimePress");
            actionTimer = 0;
            GameManager.Instance.moving = true;
            keyPres = 'a';
            animator.SetBool("IsMovLeft", true);
            animator.SetBool("IsMovRight", false);
            animator.SetBool("MissStepR", false);
            animator.SetBool("MissStepR2", false);

            arrowBar.transform.position = new Vector3(0.26f, arrowBar.transform.position.y, arrowBar.transform.position.z);

            //print("a");
            if (keyPres == prevKeyPress)
            {
                countPress++;
                countSpeed = 0;
                arrowBar.transform.position = new Vector3(-0.63f, arrowBar.transform.position.y, arrowBar.transform.position.z);
                animator.SetBool("MissStepL", true);
                //print(countPress);
            }
            else
            {
                countPress = 0;
                prevKeyPress = keyPres;
                countSpeed++;
            }
            
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            
            arrowBar.transform.position = new Vector3(0.26f, arrowBar.transform.position.y, arrowBar.transform.position.z);
            //StopCoroutine(timePress);
            //timePress = StartCoroutine("controllerTimePress");
            actionTimer = 0;
            GameManager.Instance.moving = true;
            keyPres = 'd';
            animator.SetBool("IsMovRight", true);
            animator.SetBool("IsMovLeft", false);
            animator.SetBool("MissStepL", false);
            animator.SetBool("MissStepL2", false);


            //print("d");
            if (keyPres == prevKeyPress)
            {
                countPress++;
                countSpeed = 0;
                arrowBar.transform.position = new Vector3(1.21f, arrowBar.transform.position.y, arrowBar.transform.position.z);
                animator.SetBool("MissStepR", true);
                //print(countPress);
            }
            else
            {
                countPress = 0;
                prevKeyPress = keyPres;
                countSpeed++;
            }
            
        } 
        if(countPress == 2)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {

                animator.SetBool("MissStepL2", true);
                arrowBar.transform.position = new Vector3(-1.48f, arrowBar.transform.position.y, arrowBar.transform.position.z);
               
            }
            if (Input.GetKeyDown(KeyCode.D))
            {

                animator.SetBool("MissStepR2", true);
                arrowBar.transform.position = new Vector3(2.08f, arrowBar.transform.position.y, arrowBar.transform.position.z);
               

            }
        }
        if(countPress>2)
        {
            //print("gameover");
            //Enumerator para terminar animaciones previas y darle play a la animacion de muerte
            if (Input.GetKeyDown(KeyCode.A))
            {

                animator.SetBool("FallLeft", true);
                arrowBar.transform.position = new Vector3(-1.48f, arrowBar.transform.position.y, arrowBar.transform.position.z);
                inGaming = false;
                //GameManager.Instance.isNotMoving();
                //print("rueda");
                StartCoroutine(waitGameOver());
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
                arrowBar.transform.position = new Vector3(2.08f, arrowBar.transform.position.y, arrowBar.transform.position.z);
                inGaming = false;
                //GameManager.Instance.isNotMoving();
                //print("secae");
                StartCoroutine(waitGameOver());

            }
            
        }
    }
    public void changeSpeed()
    {
        
        if (GameManager.Instance.play)
        {
            if (countSpeed < 20)
            {
                font = GetComponent<AudioSource>();
                font.pitch = 1.0f;
                //font.clip = normalSong;
          
                Debug.Log("velocidad1");
                stoppingTimer = 0.5f;
                GameManager.Instance.incrementGameSpeed(1.0f);
                //font.Stop();

            }
            if (countSpeed >= 20)
            {
                //font.Pause();
                ////font = GetComponent<AudioSource>();
                //font.clip = normalSong;
                //font.Stop(normalSong);
                font = GetComponent<AudioSource>();
                font.pitch = 1.2f;

                //font.Stop();

                Debug.Log("velocidad2");
                stoppingTimer = 1.0f;
                GameManager.Instance.incrementGameSpeed(3.0f);
                //font.Stop();
            }

            if (countSpeed >= 60)
            {
                //font.Pause();
                font = GetComponent<AudioSource>();
                font.pitch = 1.4f;

                Debug.Log("velocidad3");
                stoppingTimer = 2.0f;
                GameManager.Instance.incrementGameSpeed(7.0f);
                //font.Stop();
            }
        }
        else
        {
            animator.SetBool("FallLeft", true);
            animator.SetBool("FallRight", true);
            StartCoroutine(waitGameOver());
        }

        //print(countSpeed);
        
    }
    
    //IEnumerator controllerTimePress() //Detecta que el jugador no esta presionando nada y termina al juego
    //{
    //    Debug.Log("iniciacorutina");
    //    GameManager.Instance.isNotMoving();
    //    //GameManager.Instance.moving = false;
    //    yield return new WaitForSeconds(5);
    //    GameManager.Instance.gameOver();
    //}
    IEnumerator waitGameOver()
    {        
        yield return new WaitForSeconds(3);
        GameManager.Instance.gameOver();
    }
    private void OnTriggerEnter(Collider other)
    {
        //OTHER ES EL OBJETO CON EL QUE COLISIONAS
        Destroy(other.gameObject);

        //se destruye el objeto con el que colisionas
        print("hasta la proxima");
    }
}