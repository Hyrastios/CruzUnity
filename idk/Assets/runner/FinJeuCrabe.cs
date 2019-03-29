using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinJeuCrabe : MonoBehaviour
{
    public static bool endGame = false;
    public GameObject FinJeu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (endGame)
        {
            Time.timeScale = 0;
            spawn.activ = false;
            /*  finPartie = true;
              pdv.SetActive(false);
              End.SetActive(true);
              FinJeu.SetActive(true); */
        }

    }
}
