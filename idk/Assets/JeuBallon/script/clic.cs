using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clic : MonoBehaviour {

    private void OnMouseDown()
    {
        Destroy(gameObject);
        ScoreManager.score++;
        print("le score est de: " + ScoreManager.score);
        
    }
}
