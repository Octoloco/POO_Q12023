using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEstefanniaZEPEDA : MonoBehaviour
{
    private Rigidbody RB;
    public GameObject bala;
    public Transform balapoint;
    public float velocbala = 5;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>(); 
        //Balas();
    }

    // Update is called once per frame
    void Update()
    {
        RB.velocity = new Vector3(0, 0, +velocbala);
    }

    /*private void Disparar()
    {
        Instantiate(bala, balapoint.position, Quaternion.identity);
    }

    private void Balas()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            Disparar();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }*/
}
