using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private float health;

    [SerializeField] private GameObject deadenemy;

    // Las abejas son el enemigo
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            dead();
        }
    }

    private void dead()
    {
        Instantiate(deadenemy, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
