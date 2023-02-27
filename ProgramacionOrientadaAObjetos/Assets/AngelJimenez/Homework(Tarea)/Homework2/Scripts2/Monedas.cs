using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedas : MonoBehaviour
{
    [SerializeField] private GameObject efecto;
    [SerializeField] private float cantidadPuntos;
    [SerializeField] private Puntaje puntaje;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            puntaje.SumaDePuntos(cantidadPuntos);
            Destroy(gameObject);
        }
    }
}
