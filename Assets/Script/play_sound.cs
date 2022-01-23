using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class play_sound : MonoBehaviour
{
    public AudioSource lagu1, lagu2, touch;

    public Slider volume_music, volume_effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown(){
        touch.Play();
        touch.volume = volume_effect.value;

        if(gameObject.name == "tombol lagu 1"){
            lagu1.Play();
            lagu2.Stop();
            lagu1.volume = volume_music.value;
        }
        else{
            lagu1.Stop();
            lagu2.Play();
            lagu2.volume = volume_music.value;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
