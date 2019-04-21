using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
   
    public GameObject menuObjet;
    public GameObject bout;
    public static bool isActive = false;

    private void Start()
    {
        bout.SetActive(true);
    } 

    void Update()
    {
        isActive = menuObjet.activeInHierarchy;

        if (isActive)
        {
            menuObjet.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            menuObjet.SetActive(false);
            Time.timeScale = 1;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
             isActive = !isActive;

        if (PointDeVie.finPartie)
            bout.SetActive(false);
    }
}
