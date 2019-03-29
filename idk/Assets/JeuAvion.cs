using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class JeuAvion : MonoBehaviour
{
    public GameObject jeuav;
    public static bool newjeuav = false;
    // Update is called once per frame
    void Update()
    {
        if (jeuav.activeInHierarchy)
        {
            newjeuav = true;
            SceneManager.LoadScene("Scenes/JeuAvion");
        }
    }
}
