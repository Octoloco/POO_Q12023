using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AdivinaJuego : MonoBehaviour
{
    private int numeroRand;
    private int numeroUser;
    [SerializeField] private int intentos;
    [SerializeField] private TMP_InputField input;
    [SerializeField] private TMP_Text text;
    [SerializeField] private TMP_Text intentosText;
    [SerializeField] private GameObject restartButton;
    [SerializeField] private GameObject adivinaButton;

    void Start()
    {
        GenerarNumero();
        text.text = "Adivina mi numero!";

    }

    void Update()
    {
        intentosText.text = "Intentos: " + intentos;
    }

    public void Check()
    {
        int.TryParse(input.text, out numeroUser);

        if (numeroUser == numeroRand)
        {
            text.text = "Felicidades Ganaste! Mi numero era: " + numeroRand.ToString();
            restartButton.SetActive(true);
            adivinaButton.SetActive(false);
            
        }
        else if (numeroUser > numeroRand)
        {
            text.text = "Tu numero es muy grande!";
            intentos--;
        }
        else
        {
            text.text = "Tu numero es muy chico!";
            intentos--;
        }

        if (intentos <= 0)
        {
            text.text = "Perdiste";
            restartButton.SetActive(true);
            adivinaButton.SetActive(false);
        }


    }
    
    public void RestartGame()
    {
        intentos = 5;
        GenerarNumero();
        text.text = "Adivina mi numero!";
        input.text = "";
    }


    private void GenerarNumero()
    {
        numeroRand = Random.Range(0, 11);
    }

}
