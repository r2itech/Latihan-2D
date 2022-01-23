using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efektombol : MonoBehaviour
{
    float scaleX, scaleY;
    public Color tekan, lepas;

    // Start is called before the first frame update
    void Start()
    {
        scaleX = transform.localScale.x;
        scaleY = transform.localScale.y;
    }

    void OnMouseDown(){
        transform.localScale = new Vector2(scaleX*1.2f, scaleY*1.2f);
        GetComponent<SpriteRenderer>().color = tekan;
    }

    void OnMouseUp(){
        transform.localScale = new Vector2(scaleX, scaleY);
        GetComponent<SpriteRenderer>().color = lepas;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
