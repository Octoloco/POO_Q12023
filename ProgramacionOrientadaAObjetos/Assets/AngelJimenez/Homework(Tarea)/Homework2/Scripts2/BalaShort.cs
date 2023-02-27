using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaShort : MonoBehaviour
{
    //La destruccion de un enemigo por balas
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemigo"))
        {

            Destroy(collision.gameObject);
            Debug.Log("Destruido el enemigo");
        }
    }
}
