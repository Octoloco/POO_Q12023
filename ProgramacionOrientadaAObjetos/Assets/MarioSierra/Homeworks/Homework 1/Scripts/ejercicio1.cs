using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio1 : MonoBehaviour
{
    private void Start()//FUNCION O METODO
    {
        PlayerMarioSierra jugador = new PlayerMarioSierra();
        jugador.vida = 100;//ACCESOS QUE TENDRA EL JUGADOR
        jugador.muerte();


    }
    class PlayerMarioSierra : ActorMarioSierra //La clase PlayerMarioSierra hereda el metodo ActorMarioSierra
    {
        public int vida;//VARIABLES
        public float ataque;
        public float velocidad;
        public float fuerzaSalto;

        public void muerte()//FUNCION O METODO
        {
            Debug.Log("Has muerto");
        }
    }


    class ActorMarioSierra//CLASE
    {
        public bool dialogo;//VARIABLES
        public string nombre;
        public int daño;
        public int balas;
        public bool desaparecer;
    }
}

