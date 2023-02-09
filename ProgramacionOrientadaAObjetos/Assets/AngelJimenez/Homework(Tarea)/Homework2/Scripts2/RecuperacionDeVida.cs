using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecuperacionDeVida : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<VidaDelJugador>().Curar(20);
            Destroy(gameObject);
        }
    }
}
