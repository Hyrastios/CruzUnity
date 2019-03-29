using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killZone : MonoBehaviour {

    public static int nbkill;

    private void Start()
    {
        nbkill = 0;
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        nbkill++;
    }
    
    public int getnbkill()
    {
        return nbkill;
    }

}
