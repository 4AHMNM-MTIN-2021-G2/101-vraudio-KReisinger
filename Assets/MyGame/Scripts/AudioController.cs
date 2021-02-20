using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioController : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource softWind;
    public AudioSource heavyRainStorm;
    public AudioSource rain;
    public AudioSource softRainStorm;

    void Start()
    {
        softRainStorm.Play();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
