using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public int seconds = 0;
    public int minutes = 0;
    public GameObject textSeconds;
    public GameObject textMinutes;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("timer", 1.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(seconds>59)
        {
            minutes++;
            seconds = 0;
        }
        textSeconds.GetComponent<TextMeshProUGUI>().text = seconds + "";
        textMinutes.GetComponent<TextMeshProUGUI>().text = minutes + ":";
    }
    public void timer()
    {
      
        seconds++;
    }
}
