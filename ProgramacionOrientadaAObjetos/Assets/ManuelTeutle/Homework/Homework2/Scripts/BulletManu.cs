using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManu : MonoBehaviour
{
    [SerializeField] private float speedBullet = 20;
    [SerializeField] private float bulletCount = 5;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speedBullet * Time.deltaTime);
        DestroyBullet();
    }

    private void DestroyBullet()
    {
        bulletCount -= Time.deltaTime;

        if (bulletCount < 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
