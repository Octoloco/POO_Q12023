using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSControllerDanielTreto : MonoBehaviour
{
    CharacterController characterController;

    public float walkSpeed = 5.0f;
    public float runSpeed = 9.0f;
    public float jumpSpeed = 7.0f; //Velocidad de salto
    public float gravity = 9.0f;  //Gravedad

    private Vector3 move = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }


    void Update()
    {
        if (characterController.isGrounded)
        {
            move = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));

            if (Input.GetKey(KeyCode.LeftShift))
                move = transform.TransformDirection(move) * runSpeed;
            else
                move = transform.TransformDirection(move) * walkSpeed;

            if (Input.GetKey(KeyCode.Space))
                move.y = jumpSpeed;
        }

        move.y -= gravity * Time.deltaTime;

        characterController.Move(move * Time.deltaTime);
    }
}
