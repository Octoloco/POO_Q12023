using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1SergioAboites : MonoBehaviour
{
    public int speed = 100;
    public int health = 100;
    public int jumpForce = 100;

    private Rigidbody rb;




    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKey(KeyCode.W))
            {

                rb.AddForce(Vector3.forward * speed, ForceMode.Force);

            }

            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(Vector3.left * speed, ForceMode.Force);
            }

            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(Vector3.right * speed, ForceMode.Force);
            }

            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(Vector3.back * speed, ForceMode.Force);
            }


        }
    }
}
