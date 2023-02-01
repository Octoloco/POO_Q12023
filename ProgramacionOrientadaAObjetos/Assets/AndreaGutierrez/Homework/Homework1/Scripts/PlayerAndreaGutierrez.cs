using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAndreaGutierrez : ActorAndreaGutierrez
{
    int balas = 0;
    int armas = 0;
    int item = 0;
    int moneda = 0;
    int vidas = 0;

    // Update is called once per frame
    void Update()
    {

    }
    void atack()
    {

    }
    void Awake()
    {
    }
    void Start()
    {
    }
    void OnDestroy()
    {
    }
    void dinero()
    {
       if (moneda== 100)

        {
            moneda++;
        }
    }

}
