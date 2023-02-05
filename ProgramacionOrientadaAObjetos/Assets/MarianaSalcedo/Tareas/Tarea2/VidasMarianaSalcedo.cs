using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidasMarianaSalcedo : MonoBehaviour
{
    public int vida;
    public int maxVida = 100;

    // Start is called before the first frame update
    void Start()
    {
        vida = maxVida;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Sanar(int curar)
    {
        if ((vida + curar) > maxVida)
        {
            vida = maxVida;
        }
        else
        {
            vida += curar;
        }
    }

    public void Da�o1(int da�oEnemigo)
    {
        vida -= da�oEnemigo;
        if (vida <= 0)
        {
            Destroy(gameObject);
        }
    }
}
