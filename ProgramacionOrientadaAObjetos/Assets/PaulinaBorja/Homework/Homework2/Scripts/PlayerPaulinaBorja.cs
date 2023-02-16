using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Paulina_Borja : ActorPaulinaBorja
{
    public int food;
    public int bombs;
    public int craftMaterials;
    public bool power;
    public bool ableToCraft;

    [SerializeField] private float speed = 5;
    [SerializeField] private int life = 10;
    private float jumpForce;

    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;


    // Start is called before the first frame update
    void Start()
    {
        food = 0;
        craftMaterials = 0;
        ableToCraft = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "obstaculo")
        {
            life--;
        }

        if (collision.collider.tag == "agua")
        {
            life = 0;
        }
    }

    public void feed()
    {

    }

    public void craft()
    {
        if (craftMaterials > 3)
        {
            ableToCraft = true;
            if (ableToCraft == true)
            {
                useCraftMaterials();
            }
        }
    }

    public void releasepower()
    {
        if (power == true) { }
    }

    public void useBombs()
    {

    }

    public void useCraftMaterials()
    {

    }
}