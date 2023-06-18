using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public float acceleration = 5f; 

    private Rigidbody rb;
    private Rigidbody2D rb2d;
    private Vector2 currentVelocity;
    private Vector2 targetVelocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");


        targetVelocity = new Vector2(moveHorizontal, moveVertical) * moveSpeed;

        currentVelocity = Vector2.Lerp(currentVelocity, targetVelocity, acceleration * Time.deltaTime);

        rb.velocity = currentVelocity;


        //face to the cursor
        Vector3 mousePosition = Input.mousePosition;

        Ray mouseRay = Camera.main.ScreenPointToRay(mousePosition);
        if (Physics.Raycast(mouseRay, out RaycastHit hit))
        {
            Vector3 lookAtPoint = new Vector3(hit.point.x, transform.position.y, hit.point.z);
            transform.LookAt(lookAtPoint);
        }
    }
}


