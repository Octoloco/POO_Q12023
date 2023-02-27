using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public Transform spawnPoint;
    public Rigidbody balaPrefab;

    public float balaFuerza=1500f;
    public float balaRetroceso = 0.5f;

    public float balaTiempo= 0;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Rigidbody instanciaDeBala;
            instanciaDeBala = Instantiate(balaPrefab,spawnPoint.position, spawnPoint.rotation);
            float balaFuerza1 = balaFuerza;
            instanciaDeBala.AddForce(spawnPoint.right * 150f);

        }
    }

}
