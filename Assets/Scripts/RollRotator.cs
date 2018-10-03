using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollRotator : MonoBehaviour
{
    public Transform camera;
	
	void LateUpdate ()
    {
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, camera.localEulerAngles.z);
    }
}
