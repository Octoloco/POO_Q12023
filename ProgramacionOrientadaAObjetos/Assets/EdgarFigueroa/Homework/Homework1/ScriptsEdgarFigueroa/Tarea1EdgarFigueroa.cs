using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarea1EdgarFigueroa : MonoBehaviour
{

    void Start()
    {
       

    }
    
}

class ActorEdgarFigueroa
{
    public int vida;
    public float da�o;
    public int defensa;
    public string nombre;
    public string edad;
   

}
class PlayerEdgarFigueroa : ActorEdgarFigueroa
{
    public int resistencia;
    public string apodo;
    public float hambre;
   
    void Update()
    {
        vida = 100;
        da�o = 50;
        defensa = 60;
        resistencia = 100;
        hambre = 0;
    }
}
