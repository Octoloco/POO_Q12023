using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaShort : MonoBehaviour
{
    void Update()
    {
        //transform.Translate(Vector3.left * velocidadBala * Time.deltaTime);
    }
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            Destroy(collision.gameObject);
         
        }
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {

            Destroy(collision.gameObject);
            Debug.Log("Destruido el enemigo");
        }
    }

       
    
}
