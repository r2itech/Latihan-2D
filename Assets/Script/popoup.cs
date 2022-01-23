using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popoup : MonoBehaviour
{
    public GameObject popup;
    public bool aktif;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown(){
        popup.SetActive(aktif);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
