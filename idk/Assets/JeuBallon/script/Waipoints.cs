using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waipoints : MonoBehaviour {

    public static Transform point;

    void Awake()
    {
        point = gameObject.transform;
    }
}
