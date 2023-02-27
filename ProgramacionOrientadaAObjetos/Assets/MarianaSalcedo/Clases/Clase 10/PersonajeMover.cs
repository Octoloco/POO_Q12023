using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeMover : MonoBehaviour
{
    private Animator animeitorPersonaje;
    private SpriteRenderer VoltearPersonaje;
    void Start()
    {
        animeitorPersonaje = GetComponent<Animator>();
        VoltearPersonaje = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            animeitorPersonaje.SetBool("Correr", true);
            VoltearPersonaje.flipX = false;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animeitorPersonaje.SetBool("Correr", false);
        }

            if (Input.GetKeyDown(KeyCode.A))
            {
                animeitorPersonaje.SetBool("Correr", true);
                VoltearPersonaje.flipX = true;
            }
            if (Input.GetKeyUp(KeyCode.A))
            {
                animeitorPersonaje.SetBool("Correr", false);
            }
        }
    }
