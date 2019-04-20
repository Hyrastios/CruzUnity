using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //private float _camDistance;
    private float scene_width = 0;
    private float scene_length = 0;

    void Start()
    {
        //_camDistance = Vector3.Distance(Camera.main.transform.position, transform.position);


    }

    void Update()
    {
        if (OpenCVFaceDetection.NormalizedFacePositions.Count == 0)
            return;
        if (Camera.main.transform.position == null)
            print("Error, no camera component found");
        else
        {
            gameObject.transform.position = new Vector3(OpenCVFaceDetection.NormalizedFacePositions[0].x*scene_width, 0, OpenCVFaceDetection.NormalizedFacePositions[0].y*scene_length);
        }
        //transform.position = Camera.main.ViewportToWorldPoint(new Vector3(OpenCVFaceDetection.NormalizedFacePositions[0].x, OpenCVFaceDetection.NormalizedFacePositions[0].y, _camDistance));
    }
}
