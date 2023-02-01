using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoDaño : MonoBehaviour
{
    public int cantidad = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            other.GetComponent<VidaDaño>().retarVida(cantidad);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
            other.GetComponent<VidaDaño>().retarVida(cantidad);
    }
    

}
