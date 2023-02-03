using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEdgarF : MonoBehaviour
{
    public Slider barra; 
    public float speed = 10; 
    public float vida = 3;
    public float jump;
     public GameObject bala; 
    public Transform Arma; 
    
    void Start()
    {
        
    }

    
    void Update()
    {
     barra.value = vida;
        
        if (Input.GetKey(KeyCode.W))  
        {
            transform.Translate (0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) 
        {
            transform.Translate (0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))  
        {
            transform.Translate (speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A)) 
        {
            transform.Translate (-speed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(KeyCode.Space))
        { 
            Spawn();
        }
      if (vida<=0) 
      {   
        gameObject.SetActive(false); 
      }

    }
    private void OnCollisionEnter(Collision other)
    {
      if(other.gameObject.CompareTag("Laser"))    
        {
           vida--; 
        }  
    }
     void Spawn(){  
       Instantiate(bala,Arma.position,Quaternion.identity);
    }
    
}
