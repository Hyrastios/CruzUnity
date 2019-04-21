using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killZone : MonoBehaviour {

    public static int nbkill;

    private void Start()
    {
        nbkill = 0;
    }

    private void OnCollisionEnter(Collision other) //Lorsque le ballon touche le sol on le détruit et le nombre de vie diminue 
    {
        Destroy(other.gameObject);
        nbkill++;
    }
    
    public int getnbkill()
    {
        return nbkill;
    }

}
