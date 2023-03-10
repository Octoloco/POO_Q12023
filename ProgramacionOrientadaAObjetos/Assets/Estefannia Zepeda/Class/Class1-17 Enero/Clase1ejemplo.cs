
//Librerias por default de Unity
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Aqui empieza la clase, mismo nombre que el script
public class Clase1ejemplo : MonoBehaviour

{  //Estas llaves son el cuerpo de la clase, NADA debe ir fuera de ellas

    //Espacio para las variables, estas son primitivas y GLOBALES: todo el codigo puede acceder a ellas

    public int ejemplo; //variable publica tipo int (numeros) y su nombre.
    float ejemp; //variable privada tipo float (núm.decimales) y nombre.
    private bool Si; //variable privada tipo bool (cierto o false) y nombre.
    public char ejem; //variable publica tipo char (caracter del teclado) y nombre.
    double ejem2; //variable privada tipo double (decimales) y nombre.
    //Tambien hay tipo LOAD y STREAM.

    private int[] arreglo; //Arreglo que guarda datos tipo int
    List<string> arregloList = new List<string>(); //Nueva lista que guarda / acepta datos tipo string (letras o palabras)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Condicion
        if(Si) //aqui no lleva ;
        {
            //Accion
        }

        //De lo contrario ó si no sucede
        else
        {
            //Accion
        }

        // variable int siempre entre (), ejecuta el codigo que esta entre case y break
        switch (ejemplo)
        {
            case 1:
                ejemplo= 0;
                break;
        }

        //Declaras una variable, condicionas
        for (int i = 1; i <= ejemplo; i++)
        {
            //accion
        }
    }

    //Espacio para las Funciones
    int RegresaNumero() //Funcion de nombre RegresaNumero que "escupira" un dato tipo int
        //Si escribo ( int num ) serian datos de entrada, son variables que pueden crearse en la funcion PERO solo funcionan aqui dentro: LOCALES
    //Si fuera VOID int RegresaNumero() indico que no recibe ni da ningun dato
    {
        return 8;
        //return "hola"; ERROR, la funcion recibe int NO string
    }

}  //Estas llaves son el cuerpo de la clase, NADA debe ir fuera de ellas
