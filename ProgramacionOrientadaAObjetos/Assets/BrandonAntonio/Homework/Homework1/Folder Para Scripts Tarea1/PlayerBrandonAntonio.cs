using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBrandonAntonio : ActorBrandonAntonio

{
    private int Bullets = 7;

    public int Coins = 5;

    private int Energy = 10;

    private int Fruits = 0;

    private int Gems = 0;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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


