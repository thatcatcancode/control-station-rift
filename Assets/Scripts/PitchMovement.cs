using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchMovement : MonoBehaviour
{
    int numStepsUp = 120;
     bool up = true;
    bool initialPosFilled = false;
    int steps = 1;
    Vector3 initialPos;
    public Transform camera;
    float previousX;
    float deltaX;
    // Use this for initialization
    void Start()
    {
        previousX = camera.eulerAngles.x;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float cameraXRotation = camera.eulerAngles.x;
        Debug.Log(camera.eulerAngles.x);
        if(cameraXRotation > 180)
        {
            cameraXRotation -= 360;
        }
        deltaX = previousX - cameraXRotation;
        transform.position = new Vector3(transform.position.x, transform.position.y + deltaX, transform.position.z);
        previousX = cameraXRotation;

        //Quaternion theQuat = new Quaternion(0f, 0f, 0f, 0f);
        //Vector3 position;

        //if (initialPosFilled == false)
        //{
        //    initialPos = transform.position;
        //    initialPosFilled = true;
        //}

        //position = new Vector3(initialPos.x, initialPos.y + .6f * steps, 0);
        //transform.SetPositionAndRotation(position, theQuat);
        //if (steps >= numStepsUp )
        //{
        //   up = !up;
        //}
        //if (steps == 0)
        //{
        //    up = !up;
        //}

        //if(up == true)
        //{
        //    ++steps;
        //}
        //else
        //{
        //    --steps;
        //}
    }
}