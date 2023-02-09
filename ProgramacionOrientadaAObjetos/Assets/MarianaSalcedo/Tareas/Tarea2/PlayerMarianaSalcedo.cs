using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMarianaSalcedo : ActorMarianaSalcedo
{
    // Tarea 1
    // Características exclusivas de 1 jugador.
    private int inventario;
    private float coleccionables;
    protected int energía;
    [SerializeField] private int poder;
    [SerializeField] private int speed = 5;

    // Tarea2
    public int vida = 100;
    // public int velocidadDeMovimiento;
    // public int fuerzaDeBrinco = 10;

    void AccesarAInventario()
    {

    }

    void Empujar()
    {

    }

    void Lanzar()
    {

    }

    void Correr()
    {

    }

    void Saltar()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Movimientos de mi personaje:
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }
        //if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.Translate(Vector3.down * Time.deltaTime * speed);
        //}
        if (Input.GetKey(KeyCode.F))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.V))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
    }
}