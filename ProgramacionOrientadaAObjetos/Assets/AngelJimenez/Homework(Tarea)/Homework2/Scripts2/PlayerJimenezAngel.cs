using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJimenezAngel : ActorJimenezAngel
{
    //Variable de movimiento
    public float movimiento = 10f;
    public float vida = 10;
    public float fuerzaDeBrinco = 5;
    //variables que pueden ir en un Jugador
    private int abilidadEspecialAJ = 200;
    private string armaCelestialAJ = "Escaliburg";
    private int defensaAnimalAJ = 100;
    private int fuerzaDeAtaqueAJ = 200;
    private string tipodecriaturaAJ = "Bestia";
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
    //Metodos de Player
    void mascotaAJ()
    {

    }
    void abilidadElementalAJ()
    {

    }
    void armas()
    {

    }
    void inventario()
    {

    }
    void items()
    {

    }
    
}
