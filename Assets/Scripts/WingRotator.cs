using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingRotator : MonoBehaviour {
    int x = 10;
    int y = 10;
    int z = 10;
    Vector3 axis;

    // Use this for initialization
    void Start () {
        axis = GetComponent<Renderer>().bounds.center;
        transform.RotateAround(axis, new Vector3(0, 1, 0), 180);
    }
	
	// Update is called once per frame
	void Update () {
       //transform.rotation.SetEulerAngles(new Vector3(x, y, z));
       // transform.rotation.eulerAngles.Set(x, y, z);
       axis = GetComponent<Renderer>().bounds.center;
        //transform.RotateAround(axis, new Vector3(0, 1, 0), y * Time.deltaTime);
        //transform.RotateAround(axis, new Vector3(1, 0, 0), x * Time.deltaTime);
        //transform.RotateAround(axis, new Vector3(0, 0, 1), z * Time.deltaTime);

        transform.Rotate(transform.right, Input.GetAxis("Mouse Y"));
        transform.Rotate(transform.up, Input.GetAxis("Mouse X"));
    }
}
