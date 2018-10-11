using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class MapRotationSetter : MonoBehaviour
{
    public Vector3 xrRotation;
	// Use this for initialization
	void Start ()
    {
        if (XRDevice.isPresent)
        {
            transform.eulerAngles = xrRotation;
        }
	}
}
