using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañosMarianaSalcedo : MonoBehaviour
{
    public int vida = 5;


    public void QuitarVida(int valorVida)
    {
        vida -= valorVida;
    }
}
