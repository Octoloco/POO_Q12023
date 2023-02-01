using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAlanBonilla : ActorAlanBonilla
{
    int bullets = 60;
    int impulses = 3;
    int bandages = 5;
    int armor = 50;
    int life = 85;

    int Vida = 100;
    int VelocidaddeMovimiento = 8;
    int FuerzadeBrinco = 50;

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    [SerializeField] private float speed = 8;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))


            transform.Translate(Vector3.right * Time.deltaTime * speed);


        if (Input.GetKey(KeyCode.A))


            transform.Translate(Vector2.left * Time.deltaTime * speed);

    }
}
