using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManuel : ActorManuel
{
    [SerializeField] private int health = 5;
    [SerializeField] private int isInmune;
    protected float speed;
    public int keys;
    public float timeDash;

    private float jumpForce = 500;
    private Rigidbody rb;
    public GameObject Bullet;
    private Transform shootPoint;



    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        shootPoint = GetComponent<Transform>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        Shoot();
    }

    private void AddHealth()
    {

    }

    public void GetDamage()
    {
        health--;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void UseKeys()
    {

    }

    private void Parry()
    {

    }

    public void PowerUp()
    {

    }

    private void MovePlayer()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            rb.velocity = Vector3.up * jumpForce * Time.deltaTime;
        }
    }

    public void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            GetDamage();
        }
    }
}

