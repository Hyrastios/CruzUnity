using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clic : MonoBehaviour {

    public AudioClip sonball;
 
    private void OnMouseDown()
    {
        AudioSource.PlayClipAtPoint(sonball, gameObject.transform.position);
        Destroy(gameObject);
        ScoreManager.score++;
        print("le score est de: " + ScoreManager.score);
    }
}
