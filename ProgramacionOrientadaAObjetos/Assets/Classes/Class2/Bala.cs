using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bala : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private int puntaje;
    public bool punto;
    private TMP_Text textoPuntaje;

    // Start is called before the first frame update
    void Start()
    {
        textoPuntaje = GameObject.Find("PuntajeText").GetComponent<TMP_Text>();
        rb = GetComponent<Rigidbody>();
        puntaje = 0;
    }

    // Update is called once per frame
    void Update()
    {

        textoPuntaje.text = "Puntaje: " + puntaje.ToString();

        if (punto)
        {
            punto = false;
            puntaje++;
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
        {
            //transform.Translate(Vector3.forward * speed * Time.deltaTime);
            rb.AddForce(Vector3.forward * speed, ForceMode.Force);
        }
    }

    private void LateUpdate()
    {
        
    }
}
