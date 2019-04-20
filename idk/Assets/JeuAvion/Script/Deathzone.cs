using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Aeroplane;

public class Deathzone : MonoBehaviour
{
    Deathzone deathzone;
    AeroplaneController AC;

    private void Start()
    {
        AC = FindObjectOfType<AeroplaneController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.tag == "Player")
        {
            AC.Immobilize();
            Jeu.endGame = true;
        }
    }

}

