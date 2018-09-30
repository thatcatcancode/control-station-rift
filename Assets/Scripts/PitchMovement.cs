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
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Quaternion theQuat = new Quaternion(0f, 0f, 0f, 0f);
        Vector3 position;

        if (initialPosFilled == false)
        {
            initialPos = transform.position;
            initialPosFilled = true;
        }

        position = new Vector3(initialPos.x, initialPos.y + .6f * steps, 0);
        transform.SetPositionAndRotation(position, theQuat);
        if (steps >= numStepsUp )
        {
           up = !up;
        }
        if (steps == 0)
        {
            up = !up;
        }

        if(up == true)
        {
            ++steps;
        }
        else
        {
            --steps;
        }
    }
}