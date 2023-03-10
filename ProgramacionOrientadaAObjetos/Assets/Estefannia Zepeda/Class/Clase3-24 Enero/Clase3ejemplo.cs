using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase3ejemplo : MonoBehaviour
{ //Inicio clase

    //Un SCRIPT siempre va VINCULADO a un objeto, accedemos a su transformacion

    //Variables
    //public - private - protected son Niveles de acceso

    //Encapsulamiento: acceso limitado a variable sprivadas

    private int numero;
    public int Numero;

    //Poder editarla en Unity y no regresar al script a cada rato
    [SerializeField]private float speed = 5;

    //Rigidbody le da propiedades fisicas
    public Rigidbody r;
    //Podemos hacer referencia a objetos y guardarlos en el script

    public GameObject bala;

    // Start is called before the first frame update
    void Start()
    {
        /*Getter (agarrar) - Setter (poner)
        Get
            {
            return numero;
            }
        Set
        {
          numero = value;
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        //Transformacion de objeto. Translate lo mueve a la direccion indicada
        
        transform.Translate(Vector3.right);
        
        //Por default recorre 60 frames en 1 seg, cambiemos la distancia, desvincularlo, multiplicar por una velocidad. Entonces

        transform.Translate(Vector3.right * Time.deltaTime * speed);

        /*Unity necesita verificar cuando se cumpla una condicion, usamos un If e Input para indicarle de una tecla.
         GetKey - mientras presionas la tecla, GetKeyDown - en el frame donde presiones la tecla, GetKeyUp - cuando sueltes la tecla
        */

        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        //Para mover el objeto en cierta coordenada
        
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(1, 2, 0) * Time.deltaTime * speed);
        }
        
        //.Normalized movera a la direccion sin que sea largo el recorrido

        //Si quiero que una bala se cree varias veces, uso Instantiate (replicar) : objeto, lugar, transformacion, rotacion

        if(Input.GetKey(KeyCode.K))
        {
            //bala seria un prefab
            Instantiate(bala, transform.position, Quaternion.Euler(2, 1, 0));

            //O tambien .Identity - no necesita coordenadas
            Instantiate(bala, transform.position, Quaternion.identity);
        }

    }

    //OnCollisionEnter - cuando choca por 1ra vez, OnCollisionStay - mientras lo toca al chocar, OnCollisionExit - cuando deje de chocar
    private void OnCollisionEnter(Collision collision)
    {
        
    }

    //Los Trigger son "cuando lo toque...sucedera.."

} //Fin clase
