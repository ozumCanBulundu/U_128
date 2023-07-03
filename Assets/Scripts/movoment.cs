using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movoment : MonoBehaviour
{
    public int KeyAmount;
    public float speed = 10f;
    void Update()
    {
        float xHorizontal = Input.GetAxis("Horizontal");
        float zVertical = Input.GetAxis("Vertical");
        Vector3 moveSystem=new Vector3  (xHorizontal,0.0f,zVertical);
        transform.position += moveSystem*speed*Time.deltaTime;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Key")
        {
            KeyAmount += 1;
            Destroy(other.gameObject);

        }
    }

}
