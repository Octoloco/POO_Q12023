using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorDanielTreto : MonoBehaviour
{

    public int vidas;
    public int items;
    public bool da�o;
    public int fuerza;
    public bool velocidad;


    // Start is called before the first frame update
    void Start()
    {

        vidas = 5;
        items = 3;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*----------------------------------------------------------------------------*/
    public void Move()
    {
        
    }

    /*----------------------------------------------------------------------------*/

    public void characterGrounded()
    {
        if (isGrounded) { Move(); }
    }

    /*----------------------------------------------------------------------------*/

    public void hurt()
    {
        if (da�o == true)
        {
            vidas--;
        }
    }

    /*----------------------------------------------------------------------------*/

    public void colectCoins()
    {

    }

    /*----------------------------------------------------------------------------*/

    public void heal()
    {
        if (items == 3) { vidas++; }
    }
}



