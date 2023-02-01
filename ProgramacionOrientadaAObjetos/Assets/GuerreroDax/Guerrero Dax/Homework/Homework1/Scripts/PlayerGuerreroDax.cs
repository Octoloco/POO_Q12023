using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGuerreroDax : ActorGuerreroDax
{
    public float salto;
    public bool respawn;
    public bool golpe;
    public float velocidad = 5;
    public float velocidadderotacion = 5;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    //Porcentaje de daño;
    DañoJugador();
    
    //Respawn;
    Reaparecer();
    
    //Salto;
    HabilidadSalto();
    
    //Control;
    Mover();
    Acelerar();
    
    
    //Movimiento;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        Vector3 movementDirection = new Vector3(horizontalInput,0,verticalInput);
        movementDirection.Normalize();
        
        transform.position = transform.position + movementDirection * velocidad * Time.deltaTime;
        
        if (movementDirection != Vector3.zero)transform.rotation = Quaternion.Slerp(transform.rotation,Quaternion.LookRotation(movementDirection),velocidadderotacion * Time.deltaTime);
        
       
        
    }
}
