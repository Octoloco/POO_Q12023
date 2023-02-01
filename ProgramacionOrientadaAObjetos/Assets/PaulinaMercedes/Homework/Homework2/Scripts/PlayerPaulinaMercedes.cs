using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaulinaMercedes

{
    //movimientos del jugador.
    public float movimiento = 12f;
    public float vida = 10;
    public float fuerzaDeBrinco = 7;

    //cosas que puede hacer el jugador.

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.forward * movimiento * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-Vector3.forward * movimiento * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
            transform.Translate(-Vector3.right * movimiento * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(Vector3.right * movimiento * Time.deltaTime);


    }


    private string mezclarlosingredientes;
    private string seguirlospasosdelareceta;
    private string lavarlosingredientes;
    private string meteralhornolacomida;
    private string cocinarenlaestufa;

    void cocinar()
    {

    }
    void mezclaringredientes()
    {

    }
    void hornearlacomida()
    {

    }
    void lavarelingrediente()
    {

    }
    void cocinarlapasta()
    {

    }

}
