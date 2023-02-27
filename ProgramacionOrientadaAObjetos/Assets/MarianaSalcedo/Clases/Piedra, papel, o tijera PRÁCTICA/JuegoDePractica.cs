using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class JuegoDePractica : MonoBehaviour
{
    private int seleccionIA; //Para el número random.
    [SerializeField] private TMP_Text IATexto; //Para enlazar los textos de la interfaz con el código.
    [SerializeField] private TMP_Text PlayerTexto;
    private int inputUsuario; //Para darle valor a piedra, papel, o tijera.

    // Start is called before the first frame update
    void Start()
    {
        seleccionIA = Random.Range(1, 4); //Desde dónde empieza y el número que omite.
        IATexto.text = "¡IA Lista!"; //Cuando enlace los textos a las variables va a aparecer este texto.
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Seleccion(int seleccion) //En los paréntesis van datos de entrada.
    {
        inputUsuario = seleccion; //Se iguala al dato de entrada para que funcionen los ifs.

        if (inputUsuario == 1)
        {
            PlayerTexto.text = "Seleccionaste piedra.";
        }
        else if (inputUsuario == 2)
        {
            PlayerTexto.text = "Seleccionaste papel.";
        }
        else if (inputUsuario == 3)
        {
            PlayerTexto.text = "Seleccionaste tijeras.";
        }
    }

    public void Computadora()
    {
        if(seleccionIA == 1 && inputUsuario == 1)
        {
            IATexto.text = "Empate";
        }
        else if(seleccionIA == 2 && inputUsuario == 1)
        {
            IATexto.text = "Gana la compu";
        }
        else if (seleccionIA == 3 && inputUsuario == 1)
        {
            IATexto.text = "Ganaste";
        }

        //Con el siguiente número.
        if (seleccionIA == 1 && inputUsuario == 2)
        {
            IATexto.text = "Ganaste";
        }
        else if (seleccionIA == 2 && inputUsuario == 2)
        {
            IATexto.text = "Empate";
        }
        else if (seleccionIA == 3 && inputUsuario == 2)
        {
            IATexto.text = "Gana la compu";
        }

        //Con el siguiente número.
        if (seleccionIA == 1 && inputUsuario == 3)
        {
            IATexto.text = "Gana la compu";
        }
        else if (seleccionIA == 2 && inputUsuario == 3)
        {
            IATexto.text = "Ganaste";
        }
        else if (seleccionIA == 3 && inputUsuario == 3)
        {
            IATexto.text = "Empate";
        }
    }

    public void Reset()
    {
        SceneManager.LoadScene("Juego1");
    }

}
