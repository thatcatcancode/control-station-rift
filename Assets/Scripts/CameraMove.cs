using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    string xAxis = "Pitch";
    string yAxis = "Yaw";
    string zAxis = "Roll";

    bool isMouseBeingUsed = false;

	void Update ()
    {
        RotateCamera();
        CheckForAppQuit();
    }

    void RotateCamera()
    {
        CheckForMouse();
        Debug.Log(isMouseBeingUsed);
        xAxis = isMouseBeingUsed ? "Mouse Y" : "Pitch";
        yAxis = isMouseBeingUsed ? "Mouse X" : "Yaw";

        transform.Rotate(transform.right, Input.GetAxis(xAxis));
        transform.Rotate(transform.up, Input.GetAxis(yAxis));
        if(!isMouseBeingUsed)
        {
            transform.Rotate(transform.forward, Input.GetAxis(zAxis));
        }
    }

    void CheckForMouse()
    {
        if(Input.GetMouseButtonDown(0))
        {
            isMouseBeingUsed = !isMouseBeingUsed;
        }
    }


    void CheckForAppQuit()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Quit");
        }
    }
}