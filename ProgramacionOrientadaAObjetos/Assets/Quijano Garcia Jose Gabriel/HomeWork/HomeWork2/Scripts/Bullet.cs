using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform bulletSpawn;
    public GameObject bullet;

    public float shootforce = 2000;

    public float contador = 1f;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBullet;
            newBullet = Instantiate(bullet, bulletSpawn.position, bulletSpawn.rotation);

            newBullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward * shootforce);
         
        }


        contador-=Time.deltaTime;

        if(contador == 0)
        {
            Destroy(gameObject);
        }


    }
}
