using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GamerMov : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.forward * speed, ForceMode.Force);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.back * speed, ForceMode.Force);
        }
    }
}
