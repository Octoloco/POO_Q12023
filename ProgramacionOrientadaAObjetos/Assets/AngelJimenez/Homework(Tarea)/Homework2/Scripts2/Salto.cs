using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    public float Jumpv = 0.5f;
    public Rigidbody rb;
    public float thrust = 10;
    bool esPiso;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        esPiso = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)&& esPiso == true)
        {
            Jump();
        }
        
    }
    public void Jump()
    {
        esPiso = false;
        rb.AddForce(0, thrust, 0, ForceMode.Impulse);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Piso"))
        {
            esPiso = true;
        }
    }
}
