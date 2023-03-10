using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraLook2 : MonoBehaviour
{
    //Variables
    public new Transform camera;
    public Vector2 sensibility;

    void Start()
    {
        camera = transform.Find("Camara");
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        movimientoCamara();
    }

    public void movimientoCamara ()
    {
        float izquierdaDerecha = Input.GetAxis("Mouse X");
        float arribaAbajo = Input.GetAxis("Mouse Y");
        if (izquierdaDerecha != 0)
        {
            transform.Rotate(Vector3.up * izquierdaDerecha * sensibility.x);
        }
        if (arribaAbajo != 0)
        {
            Vector3 rotation = camera.localEulerAngles;
            rotation.x = (rotation.x - arribaAbajo * sensibility.y + 360) % 360;
            //Controlador mirar asia abajo
            if (rotation.x > 80 && rotation.x < 180) { rotation.x = 80; }
            else
            //Controlador mirar hacia arriba
                if (rotation.x < 280 && rotation.x > 180) { rotation.x = 280; }
            //camera.Rotate(-ver * sensibility.y, 0, 0);
            camera.localEulerAngles = rotation;
        }
    }
    
}
