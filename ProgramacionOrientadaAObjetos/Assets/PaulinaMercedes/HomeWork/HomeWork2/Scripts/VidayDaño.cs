using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidayDaño : MonoBehaviour
{
    public int vida = 30000;
    public bool invensible = false;
    public float tiempo_Invensible = 1f;
    public void retarVida(int cantidad)
    {
        if (!invensible && vida > 0)
        {
            vida -= cantidad;
            StartCoroutine((IEnumerator)Invensibilidad());
            if (vida == 0)
            {
                GameOver();
            }
        }
    }
    void GameOver()
    {
        Debug.Log("Has muerto.");
        Time.timeScale = 0;
    }

    IEnumerable Invensibilidad()
    {
        invensible = true;
        yield return new WaitForSeconds(tiempo_Invensible);
        invensible = false;
    }

}
