using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstController : MonoBehaviour
{
   
    private float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.moving)
        {
            speed = 5.0f;
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (!GameManager.Instance.moving)
        {
            
            speed = 0f;
        }

        

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Point")
        {
            print("PUNTO + 1");
            GameManager.Instance.incrementScore();
        }
        if (other.tag == "Player")
        {
            print("PUNTO + 1");
            GameManager.Instance.incrementScore();
        }
    }
}
