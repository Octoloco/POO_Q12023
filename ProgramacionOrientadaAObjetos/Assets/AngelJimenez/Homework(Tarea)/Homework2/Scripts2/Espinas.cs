using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espinas : MonoBehaviour
{
    [SerializeField] private float tiempoEntreDa�o;

    private float tiempoSiguienteDa�o;

    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            tiempoSiguienteDa�o -= Time.deltaTime;
            if (tiempoSiguienteDa�o<=0)
            {
                other.GetComponent<VidaDelJugador>().TomarDa�o(5);
                tiempoSiguienteDa�o = tiempoEntreDa�o;
            }
        }
    }

}
