using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObj : MonoBehaviour
{
    public GameObject gmo;

    void Update()
    {
        Destroy(gmo.gameObject);
    }
}
