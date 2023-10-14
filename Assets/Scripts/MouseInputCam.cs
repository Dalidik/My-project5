using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MouseInputCam : MonoBehaviour
{
    public float mouseSensitivity = 10f;
    public Transform playerBody;
    float xRotation;
    private void Update()
    {
        float mouseX = 0;
        float mouseY = 0;

        if(Touchscreen.current.touches.Count > 0 && Touchscreen.current.touches[0].isInProgress)
        {
            if (EventSystem.current.IsPointerOverGameObject(Touchscreen.current.touches[0].touchId.ReadValue()))
                return;
            mouseX = Touchscreen.current.touches[0].delta.ReadValue().x;
            mouseY = Touchscreen.current.touches[0].delta.ReadValue().y;
        }
        mouseX *= mouseSensitivity;
        mouseY *= mouseSensitivity;

        xRotation -= mouseY * Time.deltaTime;
        xRotation = Mathf.Clamp(xRotation, -80, 80);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        playerBody.Rotate(Vector3.up * mouseX * Time.deltaTime);
    }
}
