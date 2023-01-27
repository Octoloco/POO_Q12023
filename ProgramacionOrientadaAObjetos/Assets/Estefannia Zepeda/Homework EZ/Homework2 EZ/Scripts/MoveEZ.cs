using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEZ : MonoBehaviour
{
    public int speed = 4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.L))
        {
            transform.Translate(Vector3.right * speed);
        }

        if (Input.GetKey(KeyCode.L))
        {
            transform.Translate(Vector3.right * speed);
        }
    }
}
