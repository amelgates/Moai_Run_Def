using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //OTHER ES EL OBJETO CON EL QUE COLISIONAS
        Destroy(other.gameObject);
        //se destruye el objeto con el que colisionas
        print("hasta la proxima");
    }
}
