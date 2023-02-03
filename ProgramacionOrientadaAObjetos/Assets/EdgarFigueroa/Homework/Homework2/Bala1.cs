using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala1 : MonoBehaviour
{
public float speed; 
public float contador;
        void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime); 

        contador = contador - Time.deltaTime;
        if(contador<=0){
        Destroy(gameObject);
    
        }
    }
    private void OnTriggerEnter(Collider other) { 
    if(other.CompareTag("Enemy"))  {
         Destroy(other.gameObject); 
    }
        
    }
}
