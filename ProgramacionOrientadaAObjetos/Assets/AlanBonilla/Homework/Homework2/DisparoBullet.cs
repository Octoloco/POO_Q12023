using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoBullet : MonoBehaviour
{
    [SerializeField] private Transform shootercontrol;

    [SerializeField] private GameObject bullet;


    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            shoot();
        }

    }

    private void shoot()
    {
        Instantiate(bullet, shootercontrol.position, shootercontrol.rotation);
    }

}
