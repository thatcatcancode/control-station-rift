using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingRotator : MonoBehaviour
{
    public Transform camera;
	
	// Update is called once per frame
	void LateUpdate () {
        transform.localEulerAngles = camera.localEulerAngles;
    }
}
