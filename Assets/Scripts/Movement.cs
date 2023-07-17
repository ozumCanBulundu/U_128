using System;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public float acceleration = 5f;

    [SerializeField]private Animator animator;
    private Rigidbody rb;
    private Vector2 currentVelocity;
    private Vector3 targetVelocity;
    private CharacterController controller;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        //movement
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        movement = movement.normalized * moveSpeed * Time.deltaTime;

        if (movement.magnitude > 0f )
        {
            animator.SetBool("isMoving", true);
        }
        else
        {
            animator.SetBool("isMoving", false);
        }

        controller.Move(movement);


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


