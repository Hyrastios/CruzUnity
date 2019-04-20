using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mvcrabe : MonoBehaviour
{
    private Vector3 posi;
    public float speed;
    public GameObject crabee;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, posi, speed*Time.deltaTime);
        posi = new Vector3(transform.position.x, transform.position.y, transform.position.z - 3);

        if (transform.position.z <= 160)
            Destroy(crabee);
    }
}
