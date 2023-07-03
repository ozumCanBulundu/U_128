using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    private Animator anim;
    private bool Isopen = false;
    private bool Isclosed = true;
    private movoment keys;
    // Start is called before the first frame update
    void Start()
    {
        keys=FindObjectOfType<movoment>();
        anim= GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Isopen==true && (Input.GetKey(KeyCode.E)) && keys.KeyAmount>=1)
            {
            keys.KeyAmount -= 1;
            anim.SetTrigger("Open Door");
            Isopen = false;
            Isclosed = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Player")
        {
            Isopen = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (Isclosed == false)
        {
            anim.SetTrigger("CloseDoor");
        }
        
    }
}
