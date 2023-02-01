using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBrandonAntonio : ActorBrandonAntonio

{
 
    private int Vida;

    private int Velocidad;

    private int JumpForce;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()

    {
        if (Input.GetKey(KeyCode.W)) transform.Translate(Vector3(0, 1, 0) * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.S)) transform.Translate(Vector3(0, -1, 0) * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.D)) transform.Translate(Vector3(1, 0, 0) * Time.deltaTime * speed);
        if (Input.GetKey(KeyCode.A)) transform.Translate(Vector3(-1, 0, 0) * Time.deltaTime * speed);



    }


    private bool IsBulletAvailable()
    {

        if (Bullets > 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }


    private bool IsCoinAvailable()
    {

        if (Coins > 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }


    private bool IsEnergyAvaible()
    {

        if (Energy > 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    private void RecollectFruits()
    {
        if (Fruits > 3)
        {
            Fruits++;
        }
    }


    private void RecollectGems()
    {
        if (Gems > 3)
        {
            Gems++;
        }
    }






}


