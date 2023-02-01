using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerMarioS : MonoBehaviour
{
    private new Rigidbody rigidbody;

    public float fuerzaSalto = 5f;//representa la fuerza de salto del objeto

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 velocity = Vector3.zero;//esta variable comenzara en 0, cuando no se esta moviendo el jugador

        if (horizontal != 0 || vertical != 0)
        {                                     //Los parentesis y el .normalized es para que aunque se presionen almas direcciones al mover al jugador no se modifique la velocidad de movimiento.
            Vector3 direction = (transform.forward * vertical + transform.right * horizontal).normalized;//forward(flecha azul) y right(flecha roja) funcionan como los ejes del objeto, los cuales van  a multiplicar su valor para moverse en su misma direccion o la contraria.

            velocity = direction * speed;
        }

        velocity.y = rigidbody.velocity.y;//El componente vertical "Y" de movimeinto tendra la gravedad original del rigidbody
        rigidbody.velocity = velocity;


        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rigidbody.velocity.y) < 0.001f)//Aqui es necesario el GetKeyDown para el salto, puesto que es una tecla de impulso unico, es importante agregarle el<0.001f para que solo de un salto en el aire.
        {
            //Vector3 mas direccion siempre devuelve uno, multiplicas por valor de velocidad, multiplicas por Time.deltaTime(estabiliza los cuadros por segundo)
            //transform.position += Vector3.up * fuerzaSalto* Time.deltaTime; (Esta linea es para un salto pero no tan adecuado, da saltos en el aire)
            rigidbody.AddForce(new Vector3(0, fuerzaSalto), ForceMode.Impulse); //Esta linea ayuda a mejorar el salto.Es importante agregarle un "private" y una variable "fisica" en la parte de arriba.
        }

    }
}
