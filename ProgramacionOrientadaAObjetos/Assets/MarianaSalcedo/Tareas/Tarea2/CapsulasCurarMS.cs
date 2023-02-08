using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulasCurarMS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Personaje"))
        {
            other.GetComponent<VidasMarianaSalcedo>().Sanar(10);
            Destroy(gameObject);
        }
    }

}
