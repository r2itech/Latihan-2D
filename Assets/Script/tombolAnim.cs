using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tombolAnim : MonoBehaviour
{
    public GameObject player, artis;
    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<Animator>().speed = 0;
        artis.GetComponent<Animator>().speed = 0;
    }

    void OnMouseDown(){
        player.GetComponent<Animator>().speed = 1;
        artis.GetComponent<Animator>().speed = 1;
    }

    void OnMouseUp(){
        player.GetComponent<Animator>().speed = 0;
        artis.GetComponent<Animator>().speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
