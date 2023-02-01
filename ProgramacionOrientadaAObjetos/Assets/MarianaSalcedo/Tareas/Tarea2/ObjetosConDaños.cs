using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosConDaños : MonoBehaviour
{
    public int valorVida = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Personaje")
        {
            other.GetComponent<DañosMarianaSalcedo>().QuitarVida(valorVida);
        }
    }

    //Para quitar la vida mientras mi personaje siga sobre los objetos rojos.
    //private void OnTriggerStay(Collider other)
    //{
    //    if (other.tag == "Personaje")
    //    {
    //        other.GetComponent<DañosMarianaSalcedo>().QuitarVida(valorVida);
    //    }
    //}
}