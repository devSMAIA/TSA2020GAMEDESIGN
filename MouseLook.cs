using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float lookSpeed = 3;
    private float x;
    private float y;

    void Update()
    {
        x += Input.GetAxis("Mouse X") * lookSpeed;
        y += -Input.GetAxis("Mouse Y") * lookSpeed;
        y = Mathf.Clamp(y, -65, 18);

        transform.localEulerAngles = new Vector3(y, x, 0);
    }
}