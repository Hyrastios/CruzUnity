using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Aeroplane;

public class Deathzone : MonoBehaviour
{
    Deathzone deathzone;
    AeroplaneController AC;
    GameObject avion;

    private void Start()
    {
        AC = FindObjectOfType<AeroplaneController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (AC == null)
            Debug.Log("AC est null");
        if (other.transform.gameObject.tag == "Player")
        {
            bool b = false;
            b = AC.Immobilize();

            Jeu.endGame = true;
        }
    }

}

