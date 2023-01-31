using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{

    public GameObject bala;
    public Transform spawnPoint;

    public float fuerzaBala = 50;
    public float velocidadBala = 1f;

    private float tiempoDisparo = 0.5f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            if (Time.time > tiempoDisparo)
            {
                GameObject newBullet;
                newBullet = Instantiate(bala,spawnPoint.position,spawnPoint.rotation);
                
                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * fuerzaBala);

                tiempoDisparo = Time.time + tiempoDisparo;

                transform.Translate(Vector3.forward * fuerzaBala * Time.deltaTime);
                Destroy(newBullet, 2);
            }
        }
    }
}
