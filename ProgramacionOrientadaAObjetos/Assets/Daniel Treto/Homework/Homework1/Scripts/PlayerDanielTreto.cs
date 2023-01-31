using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDanielTreto : ActorDanielTreto
{
    private float velocidad;
    private int fuerza;
    
    protected float resistensia;
    private int punchline;

    // Start is called before the first frame update
    void Start()
    {
        velocidad = 1;
        fuerza = 3;
        punchline = true; 



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
