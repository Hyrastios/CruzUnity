using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCrabe : MonoBehaviour
{

    private Vector3 pos;
    public float speed ;
    private Quaternion rot;
    public float turnSpeed = 25f;


    private void Start()
    {
         pos = new Vector3(260, 100, 175);
        rot = new Quaternion( 20, -30, -10, 0);
       // transform.Rotate(rot);
    }

    void Update()
    {
     //   transform.Rotate(Vector3.down, -turnSpeed * Time.deltaTime);
        
        transform.position = Vector3.MoveTowards(transform.position, pos, speed * Time.deltaTime);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, turnSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftArrow) && pos.x >= 245)
        {
            pos = new Vector3(transform.position.x - 15, transform.position.y, transform.position.z);
            rot = new Quaternion(20, -30, transform.rotation.z - 20, 0);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && pos.x <= 275)
        {
            pos = new Vector3(transform.position.x + 15, transform.position.y, transform.position.z);
            rot = new Quaternion(20, -30, transform.rotation.z + 20, 0);
        }

    }
}
