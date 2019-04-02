using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Aeroplane;

public class Deathzone : MonoBehaviour
{

    public Vector3 respawnPositions;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.tag == "Player")
        {
            if (other.gameObject.GetComponent<AeroplaneController>() != null)
            {
                other.gameObject.GetComponent<AeroplaneController>().Immobilize();
                Debug.Log("Normalement t'as perdu le contrôle là");
            }
            else
            {
                Debug.Log("Le pointeur est null");
            }
        }
    }

}

