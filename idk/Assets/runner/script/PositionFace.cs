using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionFace : MonoBehaviour
{
    //private float _camDistance;
    private float scene_width = 0;
    private float scene_length = 0;
    private Vector3 pos;
    public float speed;
    private Quaternion rot;
    public float turnSpeed;

    void Start()
    {
        //_camDistance = Vector3.Distance(Camera.main.transform.position, transform.position);
        turnSpeed = 25f;
        speed = 100f;
        pos = new Vector3(260, 100, 175);
        rot = new Quaternion(20, -30, -10, 0);
    }

    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, pos, speed * Time.deltaTime);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, turnSpeed * Time.deltaTime);

        if (OpenCVFaceDetection.NormalizedFacePositions.Count == 0)
            return;
        if (Camera.main.transform.position == null)
            print("Error, no camera component found");
        else
        {
            if (OpenCVFaceDetection.NormalizedFacePositions[0].x < 0.45 && gameObject.transform.position.x <= 280)
            {
                gameObject.transform.position = new Vector3(transform.position.x + 8, transform.position.y, transform.position.z);
                gameObject.transform.rotation = new Quaternion(20, -30, transform.rotation.z - 20, 0);
            }
            else if (OpenCVFaceDetection.NormalizedFacePositions[0].x > 0.55 && gameObject.transform.position.x >= 235)
            {
                gameObject.transform.position = new Vector3(transform.position.x - 8, transform.position.y, transform.position.z);
                gameObject.transform.rotation = new Quaternion(20, -30, transform.rotation.z + 20, 0);
            }
            
            //gameObject.transform.position = new Vector3(OpenCVFaceDetection.NormalizedFacePositions[0].x*scene_width, 0, OpenCVFaceDetection.NormalizedFacePositions[0].y*scene_length);
        }
        //transform.position = Camera.main.ViewportToWorldPoint(new Vector3(OpenCVFaceDetection.NormalizedFacePositions[0].x, OpenCVFaceDetection.NormalizedFacePositions[0].y, _camDistance));
    }
}
