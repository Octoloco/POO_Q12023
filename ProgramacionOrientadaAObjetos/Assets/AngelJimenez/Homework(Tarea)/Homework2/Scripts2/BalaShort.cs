using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaShort : MonoBehaviour
{
    private int velocidadBale = 10;
    void Update()
    {
        transform.Translate(Vector3.left * velocidadBale * Time.deltaTime);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {
            Destroy(collision.gameObject);
        }
        

    }
}
