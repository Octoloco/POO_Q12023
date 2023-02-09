using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraLook2 : MonoBehaviour
{

    public new Transform camera;
    public Vector2 sensibility;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        movimientoCamara();

    }

    public void movimientoCamara ()
    {
        float hor = Input.GetAxis("Mouse X");
        float ver = Input.GetAxis("Mouse Y");


        if (hor != 0)
        {
            transform.Rotate(0, hor * sensibility.x, 0);
        }
        if (ver !=0)
        {
            Vector3 rotation = camera.localEulerAngles;
            rotation.x = (rotation.x - ver * sensibility.y + 360) % 360;
            //Controlador mirar asia abajo
            if (rotation.x > 80 && rotation.x < 180) { rotation.x = 80; }
            else
            //Controlador mirar asia arriba
                if (rotation.x < 280 && rotation.x > 180) { rotation.x = 280; }
            //camera.Rotate(-ver * sensibility.y, 0, 0);
            camera.localEulerAngles = rotation;
        }
    }
}
