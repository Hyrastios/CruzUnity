using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Détruit le ballon lorsqu'il touche un crabe

public class KillBallon : MonoBehaviour
{
        
    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.tag == "Player") 
        {
            Destroy(other.gameObject);
            FinJeuCrabe.endGame = true;
        }
    }
}

