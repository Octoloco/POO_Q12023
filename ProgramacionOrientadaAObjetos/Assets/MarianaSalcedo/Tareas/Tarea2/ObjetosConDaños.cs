using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetosConDaños : MonoBehaviour
{
    public int valorVida = 1;

    [SerializeField] private float tiempoYDaño = 1;
    private float tiempoMasDaño;

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag == "Personaje")
    //    {
    //        other.GetComponent<DañosMarianaSalcedo>().QuitarVida(valorVida);
    //    }
    //}

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag ("Personaje"))
        {
            tiempoMasDaño -= Time.deltaTime;
            if (tiempoMasDaño <= 0)
            {
                other.GetComponent<VidasMarianaSalcedo>().Daño1(valorVida);
                tiempoMasDaño = tiempoYDaño;
            }
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