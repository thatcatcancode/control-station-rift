using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchMovement : MonoBehaviour
{
    public Transform camera;
    float previousX;
    float deltaX;

    void Start()
    {
        previousX = camera.eulerAngles.x;
    }
    
    void LateUpdate()
    {
        float cameraXRotation = camera.eulerAngles.x;
        if(cameraXRotation > 180)
        {
            cameraXRotation -= 360;
        }
        deltaX = previousX - cameraXRotation;
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + deltaX * Time.deltaTime, transform.localPosition.z);
        previousX = cameraXRotation;
    }
}