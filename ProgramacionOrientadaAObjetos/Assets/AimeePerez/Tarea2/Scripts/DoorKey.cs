
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKey : MonoBehaviour
{
    
    public DoorScript doorToOpen;


    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            doorToOpen.isUnLocked = true;
        }

        Destroy(gameObject);
    }
}

