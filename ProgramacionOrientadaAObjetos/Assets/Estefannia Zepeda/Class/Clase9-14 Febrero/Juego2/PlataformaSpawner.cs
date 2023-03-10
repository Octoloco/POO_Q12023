using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlataformaSpawner : MonoBehaviour
{
    [SerializeField]private float minDistanciaY;
    [SerializeField] private float maxDistanciaX;
    [SerializeField] private float speed;
    public GameObject plataforma;
    //Cada tiempo pasa algo
    [SerializeField] private float TimeToSpawn;
    private float timereal;

    // Start is called before the first frame update
    void Start()
    {
        timereal = TimeToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        //Contador en reversa. Cada fotograma le va a restar algo entre fotogramas, cada segundo vale 1 menos
        timereal -= Time.deltaTime;
        if(timereal <= 0)
        {
            timereal = TimeToSpawn;
            float distanciarandom = Random.Range(minDistanciaY, maxDistanciaX);
            //Crear varios en cierta posicion
            //GO cacha ese objeto que se repite
            GameObject objeto = Instantiate(plataforma,new Vector3(12, distanciarandom,0),Quaternion.identity);
            objeto.GetComponent<PlataformaMov>().velocidad = speed;
        }
    }
}
