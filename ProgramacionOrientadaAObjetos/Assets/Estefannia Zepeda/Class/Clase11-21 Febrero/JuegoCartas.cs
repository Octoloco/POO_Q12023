using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuegoCartas : MonoBehaviour
{
    //public List<Carta> MazoGAMER = new List<GameObject>();
    public List<GameObject> MazoIA = new List<GameObject>();

    public int j;
    private int ia;

    public List<GameObject> ManoJugador = new List<GameObject>();
    public List<int> ManoIA = new List<int>();

    public Carta card;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("A jugar");
        //EMPEZARjuego();
        EmpezarjuegoIA();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*public void EMPEZARjuego()
    {
        for(int i = 0; i < 3; i++)
        {
            j = Random.Range(0, MazoGAMER.Count);
            //Debug.Log(j);

            //MazoGAMER[j].GetComponent<Carta>().Defensa;

            ManoJugador.Add(MazoGAMER[j]);
            MazoGAMER.RemoveAt(j);
        }
    }*/

    private void EmpezarjuegoIA()
    {
        for (int i = 0; i < 3; i++)
        {
            ia = Random.Range(0, MazoIA.Count);

            ManoIA.Add(ia);
        }
    }
}
