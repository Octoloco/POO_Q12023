using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraLook3 : MonoBehaviour
{
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

    public void movimientoCamara()
    {
        float izquierdaDerecha = Input.GetAxis("Mouse X");
        float arribaAbajo = Input.GetAxis("Mouse Y");
        if (izquierdaDerecha != 0)
        {
            transform.Rotate(Vector3.up * izquierdaDerecha * sensibility.x);
        }
        if (arribaAbajo != 0)
        {

            float angle = (camera.localEulerAngles.x - arribaAbajo * sensibility.y);
            if (angle > 180) { angle -= 360; }
            angle = Mathf.Clamp(angle, -80, 80);
            camera.localEulerAngles = Vector3.right * angle;
        }
    }
}
