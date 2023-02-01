using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{

    public GameObject bala;
    public Transform spawnPoint;

    public int fuerzaBala = 100;
    public int     velocidadBala = 10;

    private float tiempoDisparo = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (Time.time > tiempoDisparo)
            {
                GameObject newBullet;
                newBullet = Instantiate(bala,spawnPoint.position,spawnPoint.rotation);

                
                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * velocidadBala);

                tiempoDisparo = Time.time + tiempoDisparo;
                
               
                Destroy(newBullet, 1);
                Debug.Log("Disparo de bala");
            }
        }
    }
}
