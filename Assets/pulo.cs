using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulo : MonoBehaviour
{
    private CharacterController controller;
    private float verticalVelocity;
    private float gravity = 12.0f;
    private float jumpForce = 10.0f;

    void Start()
    {
        controller = GetComponent< CharacterController > ();
    }
    void Update()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
            if(Input.GetKey(KeyCode.Space))
			{
                verticalVelocity = jumpForce;
			}
        }
		else
		{
            verticalVelocity -= gravity * Time.deltaTime;
		}
        Vector3 moveVector = new Vector3(0, verticalVelocity, 0);
        controller.Move(moveVector * Time.deltaTime);
    }
}