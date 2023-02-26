using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCam : MonoBehaviour
{
    public float mousSens = 100f;
    public Transform body;
    public Transform gun1;
    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mousSens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mousSens * Time.deltaTime;

        xRotation -= mouseY;

        if (Input.GetKey(KeyCode.P))
        {
            mousSens -= 50;
        }
        if (Input.GetKey(KeyCode.L))
        {
            mousSens += 50;
        }



        xRotation = Mathf.Clamp(xRotation, -90f, 90f);


        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        body.Rotate(Vector3.up * mouseX);

    }

}
