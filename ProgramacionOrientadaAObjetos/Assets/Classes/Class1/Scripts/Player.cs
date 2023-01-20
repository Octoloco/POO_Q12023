using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Actor
{
    private int bombs = 2;
    private int keys = 0;

    private void Start()
    {
        IsItemAvailable(typeof(Bomb));
    }

    private void Update()
    {
        
    }

    private void SetBomb()
    {
        
    }

    private void UseKey()
    {

    }

    private bool IsItemAvailable(System.Type item)
    {
        if (item == typeof(Bomb))
        {
            if (bombs > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (item.GetType() == typeof(Key))
        {
            if (keys > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        Debug.LogError("That type is not an item");
        return false;
    }

    private bool IsItemAvailable(int itemIdex)
    {
        if (itemIdex == 0)
        {
            if (bombs > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else if (itemIdex == 1)
        {
            if (keys > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        Debug.LogError("That type is not an item");
        return false;
    }
}
