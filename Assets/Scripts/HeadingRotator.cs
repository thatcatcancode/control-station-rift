using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadingRotator : MonoBehaviour
{
    public Transform camera;
	
	void Start () {
		
	}
	
	void LateUpdate () {
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, camera.localEulerAngles.y);
	}
}
