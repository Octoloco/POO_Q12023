using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparos : MonoBehaviour
{
    public GameObject fuego;
    public Transform spawnPoint;

    public int fuerzaBala = 100;
    public int velocidadDeBala = 12;

    private float tiempodeDisparo = 0.5;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (Time.time > tiempoDisparo)
            {
                GameObject newBullet;
                newBullet = Instantiate(bala, spawnPoint.position, spawnPoint.rotation);


                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * velocidadDeBala);

                tiempodeDisparo = Time.time + tiempodeDisparo;


                Destroy(newBullet, 1);
                Debug.Log("EncenderEstufa");
            }
        }
    }
}
