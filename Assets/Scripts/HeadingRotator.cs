using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadingRotator : MonoBehaviour
{
    public Transform camera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, camera.eulerAngles.y);
	}
}
