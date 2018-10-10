using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorCamera : MonoBehaviour
{
    public Transform indicator;
	void LateUpdate ()
    {
        transform.position = new Vector3(indicator.position.x, transform.position.y, indicator.position.z);	
	}
}
