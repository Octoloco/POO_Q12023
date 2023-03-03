using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase6ejemplo : MonoBehaviour
{
    //Declarar listas
    List<int> ejemplolista = new List<int>();

    //Un Arreglo es de tamaño fijo
    public int[] n;


    // Start is called before the first frame update
    void Start()
    {
        //Acceder a un numero de la lista
        int numero = ejemplolista[0];

    }

    // Update is called once per frame

    /* Ejemplo en clase
     public int num1, num2, num3;

    Suma(num1, num2, num3);
        num1 = 7;
        num2 = 6;
        num3 = 5;

    int Suma( int numero1, int numero2, int numero3)
    {
        num1 + num2 + num3;
        return num1;
    }
    */
}
