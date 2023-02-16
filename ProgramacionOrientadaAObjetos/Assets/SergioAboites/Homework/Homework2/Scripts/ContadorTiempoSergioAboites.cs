using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContadorTiempoSergioAboites : MonoBehaviour
{
    public TMP_Text ContadorDeTiempo;
    public float TiempoRestante;
    public int min = 1;
    public int seg = 3;


    // Start is called before the first frame update
    private void Awake()
    {
        
    }


    void Start()
    {

        ContadorDeTiempo = GameObject.Find("ContadorTiempo").GetComponent<TMP_Text>();
        Invoke("ActualizarContador", 1f);

    }

    // Update is called once per frame
    void Update()
    {


    }

    void LateUpdate()
    {

    }

    void ActualizarContador()
    {
        seg--;
        ContadorDeTiempo.color= Color.green;
        ContadorDeTiempo.text = "Tiempo Restante: " + min + " : " + seg;

        if (min > 0 && seg == 0)
        {
            min--;
            seg = 59;
        }

        if (min == 0 && seg == 0)
        {
            ContadorDeTiempo.color = Color.red;
            ContadorDeTiempo.text = "El Tiempo se termino";
            SceneManager.LoadScene(1);
            return;
        }

        Invoke("ActualizarContador", 1f);    
    }
}
