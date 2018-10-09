using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMover : MonoBehaviour
{
    public float outerMinX;
    public float outerMaxX;
    public float outerMinZ;
    public float outerMaxZ;

    float innerMinX;
    float innerMaxX;
    float innerMinZ;
    float innerMaxZ;
    Vector3 target;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine(Move());
	}

    IEnumerator Move()
    {
        SetInnerBounds();
        target = new Vector3(Random.Range(innerMinX, innerMaxX), 0, Random.Range(innerMinZ, innerMaxZ));
        Vector3 targetDirection = target - transform.position;
        
        while(!Mathf.Approximately(transform.position.x, target.x) && !Mathf.Approximately(transform.position.z, target.z))
        {
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, Time.deltaTime, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDirection);
            transform.position += transform.forward * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        StartCoroutine(Move());
    }

    void SetInnerBounds()
    {
        innerMinX = Mathf.Clamp(transform.position.x - 10, outerMinX, outerMaxX);
        innerMaxX = Mathf.Clamp(transform.position.x + 10, outerMinX, outerMaxX);
        innerMinZ = Mathf.Clamp(transform.position.z - 10, outerMinZ, outerMaxZ);
        innerMaxZ = Mathf.Clamp(transform.position.z + 10, outerMinZ, outerMaxZ);
    }

}
