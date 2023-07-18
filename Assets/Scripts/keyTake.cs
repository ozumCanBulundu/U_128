using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyTake : MonoBehaviour
{
    public Animator animatorDoor1;
    public Animator animatorDoor2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            Destroy(other.gameObject);
            animatorDoor1.SetBool("isKeyTaken", true);
            animatorDoor2.SetBool("isKeyTaken", true);
            Debug.Log("geldi key");
        }
    }
}
