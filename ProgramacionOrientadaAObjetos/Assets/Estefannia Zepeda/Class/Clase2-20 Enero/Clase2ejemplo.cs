using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODAS las clases son PUBLICAS
//Clase2ejemplo es hijo de clase MonoBehaviour
//Herencia: pasar variables entre padres e hijos, modificar propiedades
public class Clase2ejemplo : MonoBehaviour
{
    //Si creo Clase2e1 : Clase2ejemplo    significa que sera hija de clase2ejemplo y Monobehaviour a la vez, accedera a sus variables menos las privadas


    //variables globales modificables

    public int n; // definir variable
    public int u = 6; // declarar variable

    private int m; //variable sin acceso, no pasa a los hijos, Unity no lo ve ni lo toca
    protected int e = 0; //variable que puede leerse y ver pero no editar

    //Ayuda a Unity a ver y modificar las variables privadas, no le importa.
    [SerializeField]private int ejem;

    //public Rigidbody rb;   Ejemplo

    /*Ejemplo variable de Clase2ejemplo que seria PERSONAJE
    public float correr = 6; - funcion virtual
    Clase2e1 seria Villano, hijo de personaje
    Si quiero que Villano sea mas rapido puedo usar Override: editar la funcion de padre "haz la accion de padre + otra mia"
    */


    // Start is called before the first frame update
    //Funcion de Monobehaviour, basico para gameobjects de UNITY
    void Start()
    {
        //rb.AddForce(new Vector3());   Ejemplo .Add nos da acceso a funciones de la variable Riggidbody
    }

    // Update is called once per frame
    //Funcion de padre Monobehaviour, basico para gameobjects de Unity
    void Update()
    {
        
    }

    //Polimorfismo: funcion o clase que recibe datos, puede ser generado de mas de una manera
    //Pueden crearse 5 funciones iguales con diferentes especificaciones.


    /*Ejemplo visto clase

    List<...>items = new List<item>();
    List<...>bombsList = new List<...>();

    IsItemAvailable (Typeof(Bomb));
    
    Bomb bomsTest = new Bomb();
    Key = keyTest = new Key();

    bomblist.Add(bomsTest);
    bombsList.Add(keyTest);

    items.Add(bombsTest);
    items.Add(keyTest);

    private void SetBomb()
    {

    }

    private bool IsItemAvailable(System.Type item)
    {
      if(item == typeof(Bomb))
       {
         if(bombs > 0)
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

       }
    }

    */
    
}
