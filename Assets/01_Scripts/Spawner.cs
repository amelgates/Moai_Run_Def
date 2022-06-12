using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float speed = 0.5f;


<<<<<<< Updated upstream
=======
    private void Start()
    {
          StartCoroutine(spawnObstaculeRoutine());
    }
    private void spawnObstacule()
    {
        Vector3 randomPosition = new Vector3(Random.Range(transform.position.x - 10, transform.position.x + 10),transform.position.y, transform.position.z);
        int tipo = Random.Range(1, 4);
        //debe ser 4 porque el ultimo es excluyente solo se da con enteros si trabajas con floats ambos parametros son incluyentes
        //con enteros solo el segundo es exluyente
        switch (tipo)
            //recordar siempre tener uno por defecto esto es por norma
            //digamos que se buguea el ramdom y genera 5  generando un error y como el error no se contemplo se buguea
            //default hace como si el error ya se hubiera contemblado generando algo
        {
            case 1:
                Instantiate(Obstacule1, randomPosition, Quaternion.identity);
                break;
            case 2:
                Instantiate(Obstacule2, randomPosition, Quaternion.identity);
                break;
            default :
                Instantiate(Obstacule3, randomPosition, Quaternion.identity);
                break;
        }
    }
>>>>>>> Stashed changes

    // Start is called before the first frame update
    void Start()
    {
<<<<<<< Updated upstream
        
=======
        //if (GameManager.Instance.moving == true)
        //{
        //    StartCoroutine(spawnObstaculeRoutine());
        //}
        //else if (!GameManager.Instance.moving)
        //{
        //    StopCoroutine(spawnObstaculeRoutine());
        //}
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
        transform.Translate(Vector3.forward*speed *Time.deltaTime);

=======
        while (true)
        {
            yield return new WaitForSeconds(5);
            spawnObstacule();
        }
>>>>>>> Stashed changes
    }
}
