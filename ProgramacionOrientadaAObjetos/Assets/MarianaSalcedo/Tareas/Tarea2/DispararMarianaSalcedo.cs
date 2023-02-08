using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararMarianaSalcedo : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject balas;
    public float fuerzaDisparo = 1500f;
    public float tiempoBalas = 0.5f;
    private float tiempoDisparo = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject newBala;
            newBala = Instantiate(balas, spawnPoint.position, spawnPoint.rotation);
            newBala.GetComponent<Rigidbody>().AddForce(spawnPoint.forward*fuerzaDisparo);


            Destroy(newBala, 5);
            Debug.Log("Estás disparando :)");
        }
    }
}
