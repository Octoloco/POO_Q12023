using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorDanielTreto : MonoBehaviour
{

    public int vidas;
    public int items;
    public bool daño;
    public int fuerza;
    public int velocidad;


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
        transform.position += Vector3.right * velocidad * Time.deltaTime;
    }

    /*----------------------------------------------------------------------------*/

    public void characterGrounded()
    {
       
    }

    /*----------------------------------------------------------------------------*/

    public void hurt()
    {
        if (daño == true)
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



