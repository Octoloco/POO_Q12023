using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoQuijano : MonoBehaviour
{

    [SerializeField] private float speed = 3;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime*speed);
        }
        if (Input.GetKeyUp(KeyCode.S)) 
        {
            transform.Translate(Vector3.forward* Time.deltaTime*speed);
        }
    }
}
