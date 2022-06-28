using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstController : MonoBehaviour
{
    public GameObject destroyParticles;
    public GameObject dustParticles;
    private AudioSource font;

    private float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        font = GetComponent<AudioSource>();
        font.volume = 0.0f;
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
            font = GetComponent<AudioSource>();
            font.volume = 0.0f;
        }
        if (other.tag == "Player")
        {
            font = GetComponent<AudioSource>();
            font.volume = 1.0f;
            print("PUNTO + 1");
            GameObject dustClouds = Instantiate(dustParticles, transform.position, Quaternion.identity);
            Destroy(dustClouds, 2.0f);

            GameObject cloneParticles = Instantiate(destroyParticles, transform.position, Quaternion.identity);
            //Destroy(cloneParticles, 2.0f);
            GameManager.Instance.incrementScore();
        }
    }
}
