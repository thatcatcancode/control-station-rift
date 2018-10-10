using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchMovement : MonoBehaviour
{
    public Transform camera;
    float previousXRotation;
    float deltaX;
    float maxY;
    float minY;

    void Start()
    {
        minY = transform.localPosition.y - 0.5f;
        maxY = transform.localPosition.y + 0.5f;
        previousXRotation = camera.eulerAngles.x;
    }
    
    void LateUpdate()
    {
        float cameraXRotation = camera.eulerAngles.x;
        if(cameraXRotation > 180)
        {
            cameraXRotation -= 360;
        }
        deltaX = previousXRotation - cameraXRotation;

        float newY = Mathf.Clamp(transform.localPosition.y + deltaX * Time.deltaTime, minY, maxY);
        transform.localPosition = new Vector3(transform.localPosition.x, newY, transform.localPosition.z);
        previousXRotation = cameraXRotation;
    }
}