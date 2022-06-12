using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArminMovent : MonoBehaviour
{

    private float speed = -5.0f;
   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.moving == false)
        {

            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        else if (!GameManager.Instance.moving == false)
        {
            transform.Translate(Vector3.forward * 0.0f * Time.deltaTime);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            GameManager.Instance.gameOver();
            Debug.Log("culitoconesto");
        }
    }
}
