using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndreaGutierrezGetterSetter : MonoBehaviour
{
    [SerializeField]private float speed;
    [SerializeField]private GameObject prefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
        if (Input.GetKey(KeyCode.D))
        {
            Instantiate(prefab, transform.position, Quaternion.identity);
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("floor"))
        {
            Destroy(collision.gameObject);
        }
    }
}
