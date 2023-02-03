using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public Transform door; 
    public bool isUnLocked = true;
    public float doorSpeed = 1f;
    public Transform openTransform;
    public Transform closedTransform;
    Vector3 targetPosition;
    float time;

    void Start()
    {
        targetPosition = closedTransform.position;
    }


    void Update()
    {

        if(isUnLocked && door.position != targetPosition)
        {
            door.transform.position = Vector3.Lerp(door.transform.position, targetPosition, time);
            time += Time.deltaTime * doorSpeed;
        }

    }



    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            targetPosition = openTransform.position;
            time = 0;

        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")

        {
            targetPosition = closedTransform.position;
             time = 0;
        }
    }


}

