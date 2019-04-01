using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    Deathzone deathzone;
    public bool EstFranchie { get; set; }
    private void Start()
    {
        deathzone = GameObject.Find("Deathzone").GetComponent<Deathzone>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.tag == "Player")
        {
            EstFranchie = true;
            int cptConsole = 0; 
            if (cptConsole == 0)
            {
                Debug.Log("La porte est franchie, voilà");
                cptConsole++; 
            }
            Destroy(gameObject); // Pour détruire le Checkpoint après l'avoir franchi
        }
    }
}

