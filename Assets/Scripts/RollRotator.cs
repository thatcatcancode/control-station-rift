using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollRotator : MonoBehaviour {

    bool clockwise = true;
    bool first = true;
    int steps = 0;
    int maxSteps = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ++steps;

        if (clockwise == true)
        {
            transform.Rotate(new Vector3(0, 0, 20) * Time.deltaTime);
        }
        else
        {
            transform.Rotate(new Vector3(0, 0, -20) * Time.deltaTime);
        }
         
        if(steps > maxSteps/2 && first == true)
        {
            clockwise = !clockwise;
            steps = 0;
            first = false;
        }
        if (steps > maxSteps && first == false)
        {
            clockwise = !clockwise;
            steps = 0;
        }
    }
}
