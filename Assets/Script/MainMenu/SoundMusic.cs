using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundMusic : MonoBehaviour
{
    public AudioSource music;
    public Slider MusicVolume;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown()
    {
        music.Play ();
        music.volume = MusicVolume.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
