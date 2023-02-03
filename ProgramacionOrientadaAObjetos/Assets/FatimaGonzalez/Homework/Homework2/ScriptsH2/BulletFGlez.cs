using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFGlez : MonoBehaviour
{
    public GameObject bulletFG;
    public float bulletVel;
    public float contadorFG;

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
        if (collision.gameObject.tag == "Enemigo")
        {
            Destroy(collision.gameObject);
        }
    }
}
