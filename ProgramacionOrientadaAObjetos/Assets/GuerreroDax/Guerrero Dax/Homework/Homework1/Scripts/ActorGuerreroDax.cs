using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorGuerreroDax : MonoBehaviour
{

   public int puntos;
   public int vidas;
   public bool poder;
   public bool cambiodenivel;
   public bool gameover;
   
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Puntaje();
        Vida();
        Habilidad();
        Nivel();
        PartidaTerminada();
    }
}
