using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaMarioS : MonoBehaviour
{
    public Rigidbody balaPrefab;
    public Transform origenBala;
    public float VelDisparo;
    public float tiempoDisparo;
    private float inicioDisparar;
    public float contador;

    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > inicioDisparar)//Fire1, hace referncia al click izquierdo del mouse, eso es por configuracion de Unity
        {
            inicioDisparar = Time.time + tiempoDisparo;
            Rigidbody disparo;
            disparo = Instantiate(balaPrefab, origenBala.position, Quaternion.identity);//Una vez presionado la tecla, apareceran el origen y prefab de la bala.
            disparo.AddForce(origenBala.forward * 100 * VelDisparo);



        }
    }
}
