using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VidaDelJugador : MonoBehaviour
{
    public TMP_Text vidaTexto;
    [SerializeField] private int vidaJugador;
    [SerializeField] private int maximoVida;

    void Start()
    {
        vidaJugador = maximoVida; 
    }
    private void LateUpdate()
    {
        vidaTexto.text = "Vida: "+vidaJugador+"%";
    }
    public void TomarDa�o(int da�o)
    {
        vidaJugador -= da�o;
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
