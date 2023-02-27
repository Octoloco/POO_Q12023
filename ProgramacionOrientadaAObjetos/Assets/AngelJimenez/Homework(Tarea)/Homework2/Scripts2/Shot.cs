using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{

    public GameObject bala;
    public Transform spawnPoint;

    public float fuerzaBala = 1500f;
    public float velocidadBala = 0.5f;

    private float tiempoDisparo = 0;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButton(0))
        {
            if (Time.time > tiempoDisparo)
            {
                GameObject newBullet;
                newBullet = Instantiate(bala,spawnPoint.position,spawnPoint.rotation);

                
                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * fuerzaBala);

                tiempoDisparo = Time.time + velocidadBala;
               
               
                Destroy(newBullet, 1);
                Debug.Log("Disparo de bala");
               
            }
        }
    }
}
