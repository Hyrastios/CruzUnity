using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBallon : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(Vector3.down * Time.deltaTime);
    }
}
