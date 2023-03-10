using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRepasofatimaGonzales : MonoBehaviour //esta es la clase, si no se le pone "public" automáticamente la clase se vuelve privada
{
    //private PlayerRepaso player; 

    /* Estructura de una funcion, lo primero que se escribe es el tipo de retorno */

    private int num1;  //Esta es una variable global.
    private int num2;
    private int num3;


    // Start is called before the first frame update
    void Start()
    {
        num1 = 7;
        num2 = 7;
        num3 = 7;
        int este = Resta(num1, num2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int Suma(int numero1, int numero2, int numero3)
    {
        int result = num1 + num2 + num3;
        return result;
    }

    int Resta(int numero1, int numero2, int numero3)
    {
        int result = num1 - num2 - num3;
        return result;
    }

    int Resta(int numero1, int numero2)
    {
        int result = num1 - num2;
        return result;
    }
    //toda variable que pertenece a un contexto local solo se van a poder llamar en el metodo en el cual se están declarando
    //hay dos generalizaciones de variables: globales 
    //int RegresaNumero() /* luego el nombre de la función*/
    //{

    //}

    //HERENCIA
    //Una función virtual es modificable para los hijos

    //Para declarar listas
    List<int> lista = new List<int>();

}
