using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDanielaChavéz : ActorDanielaChavéz
{
    protected int vida;
    protected int ataque;
    protected int defensa;
    protected int velocidad;
    protected int maná;

  
    [SerializeField] protected int velocidadDeMovimiento = 5;
    [SerializeField] private float fuerzaDeSalto = 8;

    public void Correr()
    { }
    public void Atacar()
    { }
    public void Curación()
    { }
    public void Bloquear() 
    { }
    public void AtaqueMágico () 
    { }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) MoverDerecha();
        if (Input.GetKey(KeyCode.A)) MoverIzquierda();
        if (Input.GetKey(KeyCode.W)) MoverAdelante();
        if (Input.GetKey(KeyCode.W)) MoverAdelante();
        if (Input.GetKey(KeyCode.S)) MoverAtras();
        if (Input.GetKey(KeyCode.Q)) Saltar();
    }

    private void MoverDerecha()
    {
        transform.Translate(Vector3.right * Time.deltaTime * velocidadDeMovimiento);
        Debug.Log("Se ejecuta correctamente algoritmo de movimiento a la derecha");
    }

    private void MoverIzquierda()
    {
        transform.Translate(Vector3.left * Time.deltaTime * velocidadDeMovimiento);
        Debug.Log("Se ejecuta correctamente algoritmo de movimiento a la izquierda");
    }

    private void MoverAdelante()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * velocidadDeMovimiento);
        Debug.Log("Se ejecuta correctamente algoritmo de movimiento adelante");
    }

    private void MoverAtras()
    {
        transform.Translate(Vector3.back * Time.deltaTime * velocidadDeMovimiento);
        Debug.Log("Se ejecuta correctamente algoritmo de movimiento hacia atrás");
    }

    private void Saltar()
    {
        transform.Translate(Vector3.up * Time.deltaTime * fuerzaDeSalto);
        Debug.Log("Se ejecuta correctamente algoritmo de movimiento adelante");
    }
}
