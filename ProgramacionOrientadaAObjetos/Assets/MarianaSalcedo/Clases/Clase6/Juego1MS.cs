using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Juego1MS : MonoBehaviour
{
    private int numeroRand;
    private int numeroUser;
    [SerializeField] private int intentos;
    [SerializeField] private TMP_InputField input;
    [SerializeField] private TMP_Text text;
    [SerializeField] private TMP_Text vintentos;

    // Start is called before the first frame update
    void Start()
    {
        GenerarNumero();
        text.text = "�Adivina mi n�mero!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MandarIntentos()
    {
        vintentos.text = "N�mero de intentos: " + intentos; 
    }
    public void Check()
    {
        // Con parse se lee un string en un int. Lo "transforma".
        int.TryParse(input.text, out numeroUser);
        if (numeroUser == numeroRand)
        {
            text.text = "�Felicidades, ganaste! Mi n�mero era: " + numeroRand.ToString();
        }
        else if (numeroUser > numeroRand)
        {
            text.text = "�Tu n�mero es muy grande!";
            intentos--;
        }
        else
        {
            text.text = "�Tu n�mero es muy chico!";
            intentos--;
        }

        if (intentos <= 0)
        {
            text.text = "�Perdiste!";
        }
    }

    private void GenerarNumero()
    {
        // N�mero inclusivo, empiezan desde el 0 y contempla todos los que se mencionen, los exclusivos no contemplan el 0 y el �ltimo n�mero.
        numeroRand = Random.Range(0, 10);
    }

    // Eventos: cuando pase algo en espec�fico, mando a llamar funciones.
}