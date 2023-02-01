using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerGabrielQuijano : ActorGabrielQuijano
{
    [SerializeField] private int lifePoints;
    public int strength, stamina, battery;
    [SerializeField] private float jumpForce = 2;
    [SerializeField] private float speed = 3;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("DarkWall"))
        {
            Destroy(gameObject);    
        }
    }

    public void moreLife ()
    {

    }
    public void moreSpeed()
    {

    }
    public void strenghtModify()
    {

    }
    public void staminaModify()
    {

    }
    public void batteryLifeMoidy()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.C))
        {
            transform.Translate(Vector3.up * Time.deltaTime * jumpForce);
        }
    }
}
