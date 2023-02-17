using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatitoMove : MonoBehaviour
{

    private Animator animatorGatito;
    private SpriteRenderer rendererGatito;
    // Start is called before the first frame update
    void Start()
    {
        animatorGatito = GetComponent<Animator>();
        rendererGatito = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            animatorGatito.SetBool("Correr", true);
            rendererGatito.flipX = false;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            animatorGatito.SetBool("Correr", false);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            animatorGatito.SetBool("Correr", true);
            rendererGatito.flipX = true;

        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            animatorGatito.SetBool("Correr", false);
        }
    }
}
