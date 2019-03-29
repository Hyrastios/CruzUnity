using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSpawn : MonoBehaviour
{
    public GameObject cra;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(cra, transform.position, Quaternion.EulerRotation(90,0,0));
        
    }

    
}
