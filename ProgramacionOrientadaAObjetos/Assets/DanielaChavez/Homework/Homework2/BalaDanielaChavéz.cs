using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaDanielaChavéz : MonoBehaviour
{
    public GameObject proyectil;
    public Transform objetovacio;


    public float velocidadBala = 1f;

    private float tiempoDisparo = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (Time.time > tiempoDisparo)
            {
                GameObject newBullet;
                newBullet = Instantiate(proyectil, objetovacio.position, objetovacio.rotation);


                newBullet.GetComponent<Rigidbody>().AddForce(objetovacio.forward);

                tiempoDisparo = Time.time + tiempoDisparo;


                Destroy(newBullet, 2);
            }
        }
    }

}
