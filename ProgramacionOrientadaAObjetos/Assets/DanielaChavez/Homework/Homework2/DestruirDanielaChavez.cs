using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirDanielaChavez : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("floor"))
        {
            Destroy(collision.gameObject);
            Debug.Log("El jugador ha sido destruido");
        }


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
