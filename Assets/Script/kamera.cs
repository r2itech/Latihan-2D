using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    public GameObject player;
    public float jarak;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(player.transform.localPosition.x + player.transform.localScale.x*jarak,0,-10);
        transform.localPosition = Vector3.Slerp(transform.localPosition, pos, 0.05f);
    }
}
