using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class SoundManager : MonoBehaviour
{
   public AudioMixer audioMixer;


    [SerializeField] Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   public void ChangeVolume( )
    {
        audioMixer.SetFloat("SonidoVolumen", volumeSlider.value);
    }

}
