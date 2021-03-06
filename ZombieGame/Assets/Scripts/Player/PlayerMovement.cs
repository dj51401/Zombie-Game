﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
        //move varialbes
    public CharacterController controller;

    public float walkSpeed = 8.0f;
    public float runSpeed = 16.0f;
    public float gravity = -9.81f;
    public float jumpHeight = 3.0f;

    //gravity variables
    public Transform groundCheck;
    public float groundDistance = .4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {

        #region Movement
        //is grounded =                   ground check    is    ground distance from ground 
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        // move it at the speed
        if (Input.GetKey(KeyCode.LeftShift))
        {
            controller.Move(move * runSpeed * Time.deltaTime);
        }
        else
        {
            controller.Move(move * walkSpeed * Time.deltaTime);
        }

        //if on the ground and you push jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //jump
            velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        }

        //apply gravity
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        #endregion
    }
}
