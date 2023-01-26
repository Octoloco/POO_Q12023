using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboMoveFG : MonoBehaviour
{
    [SerializeField] private float speedFG = 5;
    [SerializeField] GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speedFG);
            //transform.Translate(new Vector3(1,1,0) * Time.deltaTime * speedFG);
        }

        //forward=frente, Back=atras, Right=derecha, Left=Izquierda...
        //Normalizar el vector para todos lados

        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
            //Quaternions son angulos de rotación, en este caso es 0.
            //Una instancia es una copia de algo.
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("floor"))
        {
            Destroy(collision.gameObject);
        }
    }
}
