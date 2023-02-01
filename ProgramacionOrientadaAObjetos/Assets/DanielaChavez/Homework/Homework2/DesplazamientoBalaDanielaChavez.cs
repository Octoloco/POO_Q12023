using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesplazamientoBalaDanielaChavez : MonoBehaviour
{

    private float speed2 = 3;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(collision.gameObject);
            Debug.Log("Algoritmo de destrucción ejecutado");
        }


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed2);
    }
}
