using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JuegoAdivina : MonoBehaviour
{
    //Variables
    private int NumRandom;
    private int NumUser;
    [SerializeField] private int Intentos = 5;
    [SerializeField] private TMP_InputField numinput; //Es una referencia al Input
    [SerializeField] private TMP_Text texto;
    public TMP_Text cuentavidas;
    public GameObject boton1;
    public GameObject boton2;

    // Start is called before the first frame update
    void Start()
    {
        cuentavidas.text = "Vidas:" + Intentos;
        texto.text = "Adivina el número";
        GenerarNumero();
        boton1.SetActive(true);
        boton2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Check()
    {
        int.TryParse(numinput.text, out NumUser);
        if (NumUser == NumRandom) //Compara
        {
            texto.text = "¡Es el número correcto! Felicidades. Si era: " + NumRandom.ToString();
            VolverJugar();
            boton1.SetActive(false);
            boton2.SetActive(true);
        }

        else if (NumUser > NumRandom)
        {
            texto.text = "Tu numero es más grande :I";
            Intentos--;
            cuentavidas.text = "Vidas:" + Intentos.ToString();
        }

        else  //Si no es grande, obviamente es muy chico
        {
            texto.text = "Tu numero es muy chico :(";
            Intentos--;
            cuentavidas.text = "Vidas:" + Intentos.ToString();
        }

        if (Intentos <= 0)
        {
            texto.text = "Sin intentos.Perdiste >:(";
            cuentavidas.text = "Vidas:" + Intentos.ToString();

            VolverJugar();
            boton1.SetActive (false);
            boton2.SetActive (true);
        }
    }

    private void GenerarNumero()
    {
        NumRandom = Random.Range(0, 11);
    }

    public void VolverJugar()
    {
        Intentos = 5;
        cuentavidas.text = "Vidas:" + Intentos;
        texto.text = "Adivina el número";
        GenerarNumero();
        boton1.SetActive(true);
        boton2.SetActive(false);
    }
}
