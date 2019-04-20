using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawn : MonoBehaviour
{
    public GameObject cra;
    public GameObject sph;
  
    void Start()
    {
        Instantiate(cra, transform.position, Quaternion.EulerRotation(90, 0, 0));
        Instantiate(sph, transform.position, Quaternion.EulerRotation(90, 0, 0));
    }

    
}
