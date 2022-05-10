using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Obstacule1;
    public GameObject Obstacule2;
    public GameObject Obstacule3;


    private void Start()
    {
        StartCoroutine(spawnObstaculeRoutine());
    }
    private void spawnObstacule()
    {
        Vector3 randomPosition = new Vector3(Random.Range(transform.position.x - 5, transform.position.x + 5),transform.position.y, transform.position.z);
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
    IEnumerator spawnObstaculeRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            spawnObstacule();

        }
    }
}
