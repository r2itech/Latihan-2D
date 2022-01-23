using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class partikel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posMouse = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
        transform.position = new Vector3(posMouse.x, posMouse.y, posMouse.z);
    }
}
