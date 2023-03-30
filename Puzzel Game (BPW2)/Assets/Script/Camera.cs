using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera: MonoBehaviour
{

    public float lookSensitivity;
    public Transform target;
    public Transform player;

    float mouseX;
    float mouseY;

     void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * lookSensitivity;

        transform.LookAt(target);

        player.rotation = Quaternion.Euler(0, mouseX, 0);
        target.rotation = Quaternion.Euler(-mouseY, mouseX, 0);
    }

}
