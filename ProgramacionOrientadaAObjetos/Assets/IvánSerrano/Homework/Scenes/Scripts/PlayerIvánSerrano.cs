using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerIvánSerrano : MonoBehaviour
{
    public int ActorIvánSerrano;
    public float jumpForceIv = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            transform.position += new Vector3(0, 1f, 0);
        }
        if (Input.GetKeyDown(KeyCode.S)) 
        {
            transform.position += new Vector3(0, -1f, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-1f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1f, 0, 0);
        }
        
    }
}
