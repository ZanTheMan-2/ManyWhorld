using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pMovement : MonoBehaviour
{

    public Rigidbody Rigid;
    public float MouseSensitivity;
    public float MoveSpeed;
    public float JumpForce;

    public bool grounded;

    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, Vector3.down, 2))
        {
            print("grounded");
            grounded = true;
        }
        else
            grounded = false;
    }

    void Update()
    {
        Rigid.MovePosition(transform.position + (transform.forward * Input.GetAxis("Vertical") * MoveSpeed) + (transform.right * Input.GetAxis("Horizontal") * MoveSpeed));

        if (grounded == true) { 
        if (Input.GetKeyDown("space"))
            Rigid.AddForce(transform.up * JumpForce);
        }
    }
}