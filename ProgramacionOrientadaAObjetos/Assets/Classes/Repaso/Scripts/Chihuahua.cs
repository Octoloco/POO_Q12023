using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chihuahua : Perro
{
    List<int> lista = new List<int>();
    public int[] arreglo = new int[4];

    new int patas = 3;

    public GameObject bala;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bala, transform.position, Quaternion.identity);
        }

    }

    private void Nadar()
    {
        Salta();
    }

    private void Accidente()
    {
        patas = 3;
    }
}
