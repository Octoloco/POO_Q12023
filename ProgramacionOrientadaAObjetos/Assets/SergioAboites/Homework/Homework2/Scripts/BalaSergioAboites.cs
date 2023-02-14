using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaSergioAboites : MonoBehaviour
{
    public int speed = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collisionbala)
    { 
      /*if (CompareTag("Pilar"))
        {
            Destroy(gameObject);
        }*/

        if (collisionbala.gameObject.tag == "Enemy")
        {
            Destroy(collisionbala.gameObject);
            Destroy(gameObject);
        }
    }



    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
