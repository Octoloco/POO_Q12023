using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaDelJugador : MonoBehaviour
{
    [SerializeField] private int vidaJugador;
    [SerializeField] private int maximoVida;

    void Start()
    {
        vidaJugador = maximoVida; 
    }

   
    void Update()
    {
        
    }

    public void TomarDaño(int daño)
    {
        vidaJugador -= daño;
        if(vidaJugador<=0)
        {
            Destroy(gameObject);
        }
    }
    public void Curar(int curacion)
    {
        if ((vidaJugador+curacion)>maximoVida)
        {
            vidaJugador = maximoVida;
        }
        else
        {
            vidaJugador += curacion;
        }
    }
}
