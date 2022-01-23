using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlTouch : MonoBehaviour
{
    public GameObject player, peluru, pos_peluru;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown(){
        if(gameObject.name == "tombol kiri"){
            
        }
        else if(gameObject.name == "tombol kanan"){

        }
        else if(gameObject.name == "tombol loncat"){
            player.GetComponent<player>().melompat();
        }
        else if(gameObject.name == "tombol peluru"){
            Instantiate(peluru, pos_peluru.transform.position, pos_peluru.transform.rotation);
        }
    }

    void OnMouseUp(){
        if(gameObject.name == "tombol kiri"){
            player.GetComponent<player>().berhenti();
        }
        else if(gameObject.name == "tombol kanan"){
            player.GetComponent<player>().berhenti();
        }
        else if(gameObject.name == "tombol loncat"){
            
        }
    }

    void OnMouseDrag(){
        if(gameObject.name == "tombol kiri"){
            player.GetComponent<player>().jalanKiri();
        }
        else if(gameObject.name == "tombol kanan"){
            player.GetComponent<player>().jalanKanan();
        }
        else if(gameObject.name == "tombol loncat"){
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
