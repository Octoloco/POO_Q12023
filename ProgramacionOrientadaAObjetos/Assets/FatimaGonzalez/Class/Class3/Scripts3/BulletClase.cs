using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletClase : MonoBehaviour
{

    public float speed;
    public GameObject bala;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); //El vector 3 forward hace que el objeto se mueva hacia adelante 
        if(Input.GetKey(KeyCode.Space)) 
        {
            Instantiate(bala, transform.position, Quaternion.identity);
        }
    }
}
