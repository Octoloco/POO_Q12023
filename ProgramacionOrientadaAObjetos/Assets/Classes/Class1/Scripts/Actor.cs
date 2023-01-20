using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    [Header("Basic Attributes")]
    public int health;
    [SerializeField] protected float speed;
    [SerializeField] private float jumpForce;
    protected float damage;
    private bool isGrounded;
    

    void Start()
    {
        
    }

    void Update()
    {

    }

    public virtual void Move()
    {
        speed = 6;
    }

    private void Jump()
    {

    }

    public void ReduceHealth(int damage)
    {
        health -= damage;
    }

    
}
