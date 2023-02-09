using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraLook1 : MonoBehaviour
{
    public float mouseSensitivity = 80;
    public Transform playerBody;
    float xRotation = 0;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation += mouseY;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
       
       // transform.localPosition = Quaternion.Euler();

        playerBody.Rotate(Vector3.up * mouseX);
    }
}
