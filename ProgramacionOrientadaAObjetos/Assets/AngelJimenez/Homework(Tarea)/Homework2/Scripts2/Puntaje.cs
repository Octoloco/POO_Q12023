using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    private float puntos;
    private TextMeshProUGUI textMesh;
    void Update()
    {
        puntos += Time.deltaTime;
        textMesh.text = puntos.ToString("0");
    }
    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }
    public void SumaDePuntos(float puntosEntrada)
    {
        puntos += puntosEntrada;
    }

}
