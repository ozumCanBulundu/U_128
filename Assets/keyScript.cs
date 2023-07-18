using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyScript : MonoBehaviour
{
    public Animator animatorDoor1;
    public Animator animatorDoor2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            animatorDoor1.SetBool("isKeyTaken", true);
            animatorDoor2.SetBool("isKeyTaken", true);
        }
    }
}
