using UnityEngine;

public class GoogleMap : MonoBehaviour
{
    public GameObject cameraFrame;
    Quaternion theRotation;
    void Start()
    {
        theRotation = cameraFrame.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        theRotation.x = transform.rotation.x - cameraFrame.transform.rotation.x;
        theRotation.y = transform.rotation.y - cameraFrame.transform.rotation.y;
        theRotation.z = transform.rotation.z - cameraFrame.transform.rotation.z;

//        transform.rotation = theRotation - cameraFrame.transform.rotation;
    }
}