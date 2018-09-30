using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    Vector3 axis;

    // Use this for initialization
    void Start () {
        //axis = GetComponent<Renderer>().bounds.center;
    }
	
	// Update is called once per frame
	void LateUpdate () {

        //Capturing mouse movements for smoother experience
        //RotateAround is deprecated
        transform.Rotate(transform.right, Input.GetAxis("Mouse Y"));
        transform.Rotate(transform.up, Input.GetAxis("Mouse X"));

        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    transform.Rotate(transform.right, 10);
        //}
        //else if (Input.GetKeyDown(KeyCode.A))
        //{
        //    transform.RotateAround(axis, new Vector3(0, 1, 0), -10);
        //}
        //else if (Input.GetKeyDown(KeyCode.S))
        //{
        //    transform.RotateAround(axis, new Vector3(1, 0, 0), -10);
        //}
        //else if (Input.GetKeyDown(KeyCode.D))
        //{
        //    transform.RotateAround(axis, new Vector3(0, 1, 0), 10);
        //}
    }
}
