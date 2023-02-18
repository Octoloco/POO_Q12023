using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class PlayerBrandonAntonio : ActorBrandonAntonio

//{

//   public Transform bulletSpawnPoint;
//   public GameObject bulletPrefab;
//    public float Contador;
//    public float bulletSpeed = 10;

//   private int Vida;

//     private int Velocidad;

//      private int JumpForce;

// Start is called before the first frame update
//  void Start()
// {

// }
// Update is called once per frame
// void Update()

// {
//      if (Input.GetKey(KeyCode.W)) transform.Translate(Vector3(0, 1, 0) * Time.deltaTime * speed);
//      if (Input.GetKey(KeyCode.S)) transform.Translate(Vector3(0, -1, 0) * Time.deltaTime * speed);
//      if (Input.GetKey(KeyCode.D)) transform.Translate(Vector3(1, 0, 0) * Time.deltaTime * speed);
//      if (Input.GetKey(KeyCode.A)) transform.Translate(Vector3(-1, 0, 0) * Time.deltaTime * speed);

//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
//            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
//        }

//        Contador -= Time.deltaTime;
//        if (Contador <= 0.0f)
//        {
//            Destroy(gameObject);

//     }


// private void OnCollisionEnter(Collision collision)
// {
//   if (collision.collider.tag == "ENEMIGO")
//  {
//      Vida - 1;
//  }
// }

//  }

//}

