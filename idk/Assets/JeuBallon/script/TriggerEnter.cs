using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnter : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        print("je suis dans le waipoint.");
        Destroy(other.gameObject);
    }
}
