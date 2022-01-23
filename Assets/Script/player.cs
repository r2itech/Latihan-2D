using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float kecepatan, scaleX, lompat;

    // Start is called before the first frame update
    void Start()
    {
        scaleX = transform.localScale.x;
    }

    public void jalanKiri(){
        if(GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("diam")){
            GetComponent<Animator>().SetTrigger("jalan");
        }
        transform.localScale = new Vector3(-scaleX, transform.localScale.y, transform.localScale.z);
        transform.Translate(Vector3.left*kecepatan*Time.fixedDeltaTime, Space.Self);
    }

    public void jalanKanan(){
        if(GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("diam")){
            GetComponent<Animator>().SetTrigger("jalan");
        }
        transform.localScale = new Vector3(scaleX, transform.localScale.y, transform.localScale.z);
        transform.Translate(Vector3.right*kecepatan*Time.fixedDeltaTime, Space.Self);
    }

    public void berhenti(){
        GetComponent<Animator>().SetTrigger("stop");
    }
    public void melompat(){
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, lompat);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)){
            jalanKiri();
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            jalanKanan();
        }
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            melompat();
        }
        if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow)){
            berhenti();
        }
    }
}
