using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Checkpoint : MonoBehaviour
{
    public AudioClip bip; 
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
            if (!EstFranchie)
            {
                EstFranchie = true;
                Jeu.NbPorteFranchie = Jeu.NbPorteFranchie + 1;
                AudioSource.PlayClipAtPoint(bip, gameObject.transform.position);
            }
            Destroy(gameObject); // Pour détruire le Checkpoint après l'avoir franchi
        }
    }
}

