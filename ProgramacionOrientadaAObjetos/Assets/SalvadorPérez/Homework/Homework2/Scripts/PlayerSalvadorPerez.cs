using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSalvadorPerez : ActorSalvadorPerez
{
    int bombs = 0;
    int mana = 10;
    int coins = 10;
    int stamina = 15;
    int lives = 5;

    // Update is called once per frame
    void Update()
    {
        
    }

    void ManaRegen()
    {

    }

    void ParryAttk()
    {

    }

    void LowerStamina()
    {

    }

    void SpecialMove()
    {

    }

    void AddLive()
    {
        if (coins == 100)
        {
            lives++;
        }
    }
}
