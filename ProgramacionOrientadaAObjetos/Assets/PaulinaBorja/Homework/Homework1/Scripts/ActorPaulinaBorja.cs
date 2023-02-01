using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActorPaulinaBorja : MonoBehaviour
{
    public int life;
    public int coins;
    public bool damage;
    public float speed;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        life = 3;
        coins = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Move()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    public void characterGrounded()
    {
        if (isGrounded) { Move(); }
    }

    public void hurt()
    {
        if (damage == true)
        {
            life--;
        }
    }

    public void colectCoins()
    {

    }

    public void heal()
    {
        if (coins == 5) { life++; }
    }
}
