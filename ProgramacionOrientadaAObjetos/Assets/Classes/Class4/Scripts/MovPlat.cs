using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPlat : MonoBehaviour
{
    public float vel;


    void Update()
    {
        transform.Translate(Vector3.left * vel * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("pared"))
        {
            Destroy(gameObject);
        }
    }
}
