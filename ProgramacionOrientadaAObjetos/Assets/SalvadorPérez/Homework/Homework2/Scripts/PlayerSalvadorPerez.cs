using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSalvadorPerez : ActorSalvadorPerez
{
    int bombs = 0;
    int mana = 10;
    int coins = 10;
    int stamina = 15;
    int lives = 5;
    [SerializeField] private float speed;
    [SerializeField] private GameObject prefab;

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
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }

    void ManaRegen()
    {

    }

    void ParryAttk()
    {

    }

    void LowerStamina()
    {

    }

    void SpecialMove()
    {

    }

    void AddLive()
    {
        if (coins == 100)
        {
            lives++;
        }
    }
}
