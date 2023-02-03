using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player2EstefanniaZepeda : ActorEstefanniaZepeda 
{
    public Rigidbody rb;
    public TextMeshProUGUI texto;
    public GameObject enemigo;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 8;
        jump = 5;
        life = 5;
        texto.text = "Vidas:" + life;

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.F))
        {
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.B))
        {
            transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.up * jump * Time.deltaTime, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            life--;
            texto.text = "Vidas:" + life;

            if(life <= 0)
            {
                Debug.Log("No quedan vidas. Perdiste :(");
            }
        }
    }
}
