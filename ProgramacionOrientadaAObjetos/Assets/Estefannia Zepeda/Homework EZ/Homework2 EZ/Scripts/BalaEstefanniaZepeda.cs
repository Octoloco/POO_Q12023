using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaEstefanniaZepeda : MonoBehaviour
{
    public float speedbala = 4;

    // Start is called before the first frame update
    void Update()
    {
        transform.Translate(Vector3.forward * speedbala * Time.deltaTime);

        //Destroy(gameObject, 0.7f);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(other);
        }
    }
}
