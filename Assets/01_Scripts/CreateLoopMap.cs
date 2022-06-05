using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateLoopMap : MonoBehaviour
{
    public GameObject backFloor;
    public GameObject floor;
    public GameObject floorSpawn;

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
        if( other.CompareTag("Floor"))
        {
            floor.transform.position = floorSpawn.transform.position;
        }
        if (other.CompareTag("BackFloor"))
        {
            backFloor.transform.position = floorSpawn.transform.position;
        }

    }
}
