using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodbyeBulletMarioS : MonoBehaviour
{
    public float contador = 5f;

    private void Update()
    {
        contador = contador - (Time.deltaTime);

        if (contador == 0f && gameObject.tag == "bala")
        {
            Destroy(gameObject);
        }
    }
}