using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1SergioAboites : MonoBehaviour
{
    public int speed = 100;
    public int health = 100;
    public int jumpForce = 100;



    // Start is called before the first frame update
    void Start()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.CompareTag("Enemy"))
        {
            health = health--;
        }
    }
    void OncollisionEnter(Collider col)
    {

    }

            // Update is called once per frame
            void Update()
    {
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.back * speed * Time.deltaTime);
            }
        }
    }
}
