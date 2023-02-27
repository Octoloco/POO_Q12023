using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorDePlataforma : MonoBehaviour
{
    [SerializeField] private float minDistY;
    [SerializeField] private float maxDistX;
    [SerializeField] private float speed;
    [SerializeField] private GameObject plataforma;
    [SerializeField] private float timeToSpawn;

    private float timer;

    void Start()
    {
        timer = timeToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        timer-=Time.deltaTime;
        if (timer <= 0)
        {
            timer = timeToSpawn;
            
            float distRandom=Random.Range(minDistY,maxDistX);


            GameObject objeto= Instantiate(plataforma,new Vector3(15,distRandom,0), Quaternion.identity);
            objeto.GetComponent<Movimiento>().vel = speed;
        }
    }
}
