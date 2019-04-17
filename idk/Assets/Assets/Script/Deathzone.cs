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
            Debug.Log("On est avec un joueur");
            Debug.Log(AC);

            bool b = false;
            b = AC.Immobilize();
            if (b)
            {
                Debug.Log("on a bien appellé");
            }
            else Debug.Log("Il y a eu un soucis"); 

        }

        /*
        if (other.transform.gameObject.tag == "Player")
        {
            if (other != null)
            {
                Debug.Log("Other n'est pas nul");
            }
            if (other.GetComponent<AeroplaneController>() != null)
            {
                other.GetComponent<AeroplaneController>().Immobilize();
                Debug.Log("other.GetComponent<AeroplaneController>() n'est pas nul");
            }
            if (other.gameObject.GetComponent<AeroplaneController>() != null)
            {
                other.gameObject.GetComponent<AeroplaneController>().Immobilize();
                Debug.Log("Normalement t'as perdu le contrôle là");
            }
            else
            {
                Debug.Log("Le pointeur est null, t'as pas perdu le contrôle");
            }
            Debug.Log("On va détruire");
            Destroy(other);
            if (other != null)
            {
                Debug.Log("Le pointeur vers other n'est pas nul");
            }
            else Debug.Log("Le pointeur est nul, logiquement t'as plus de contrôle");
            other.GetComponentInChildren<AeroplaneController>().Immobilize();
            other.GetComponentInParent<AeroplaneController>().Immobilize();
         }
         */

        
    }

}

