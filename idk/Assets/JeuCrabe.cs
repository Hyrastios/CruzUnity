using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class JeuCrabe : MonoBehaviour
{
    public GameObject jeucrabe;
    public static bool newjeucrab = false;
    // Update is called once per frame
    void Update()
    {
        if (jeucrabe.activeInHierarchy)
        {
            newjeucrab = true;
            SceneManager.LoadScene("Scenes/Runner");
        }
    }
}

