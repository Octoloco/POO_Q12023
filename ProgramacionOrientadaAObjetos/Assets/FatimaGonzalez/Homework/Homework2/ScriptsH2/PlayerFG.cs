using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFG : MonoBehaviour
{
    public float velocidadFG = 0.5f;
    public float saltoFG = 10.0f;
    public GameObject personaje;
    public int vidaupF;
    public int vidainF;
    public int da�oF;

    // Start is called before the first frame update
    void Start()
    {
        personaje.gameObject.SetActive(true);
        vidaupF = 3;
        vidainF = 3;
        da�oF = 1;
        Debug.Log("Vidas: " + vidaupF + "/" + vidainF);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate (Vector3.back * velocidadFG * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate (Vector3.forward * velocidadFG * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate (Vector3.left * velocidadFG * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate (Vector3.right * velocidadFG * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.up * saltoFG * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Enemigo")
        {
            vidaupF = da�oF;

            if (vidaupF < 1)
            {
                da�oF--;
                Debug.Log ("Vidas: " + vidaupF + "/" + vidainF);
                Debug.Log ("Game Over");
            }
            if (vidaupF < 2)
            {
                da�oF--;
                Debug.Log ("Vidas: " + vidaupF + "/" + vidainF);
            }
            if (vidaupF == 0) 
            {
                personaje.gameObject.SetActive(false);
                Debug.Log("Perdiste");
            }
        }
        Debug.Log ("Vidas: " + vidaupF + "/" + vidainF);
    }
}
