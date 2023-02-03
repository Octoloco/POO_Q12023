using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalitasDisparosMS : MonoBehaviour
{
    public GameObject balaPrefab;
    public Transform spawnPoint;
    public float fuerzaDisparo = 10;
    //public int cantidadProyectil;
    //public int segundaBala;
    //private float tiempoDeDisparo = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Instantiate(balaPrefab, transform.position, Quaternion.identity);
        }

        // NOTA: Profe, no pude hacer que funcionara lo de las balas en mi proyecto, no supe cómo debía relacionar las cosas en Unity, prometo mejorar :c
        //        segundaBala = Instantiate(balaPrefab, spawnPoint.position, spawnPoint.rotation);

        //        segundaBala.GetComponent<RigidBody>().AddForce(spawnPoint.forward*fuerzaDisparo);

        //        tiempoDeDisparo = Time.time + cantidadProyectil;

        //        Destroy(segundaBala, 3);
    }
}
