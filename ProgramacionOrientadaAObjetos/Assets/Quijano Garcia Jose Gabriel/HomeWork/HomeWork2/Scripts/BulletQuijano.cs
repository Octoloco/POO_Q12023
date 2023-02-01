using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletQuijano : MonoBehaviour
{
    public Transform bulletSpawn;
    public GameObject bullet;

    public float shootforce = 2000;

   /* public float contador = 1f;*/

    

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
            Destroy(newBullet, 0.5f);
        }


        /*contador-=Time.deltaTime;

        if(contador == 0)
        {
            Destroy(gameObject);
        }
        */

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
        }

    }

}
