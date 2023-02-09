using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarEnemigosMarianaSalcedo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ENEMIGO"))
        {

            Destroy(collision.gameObject);
            Debug.Log("Derrotaste un enemigo");
        }
    }
}
