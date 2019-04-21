using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Recommence une partie (pour les jeux ballon et crabe)

public class RestartGame : MonoBehaviour
{
    Scene scene;  
    public GameObject newg;

    private void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    void Update()
    {
        if (JeuBallon.newjeuball)
        {
            SceneManager.LoadScene(scene.buildIndex);
            JeuBallon.newjeuball = false;
        }

        if (JeuCrabe.newjeucrab)
        {
            SceneManager.LoadScene(scene.buildIndex);
            JeuCrabe.newjeucrab = false;
        }

        if (newg.activeInHierarchy)
        {
            SceneManager.LoadScene(scene.buildIndex);
            newg.SetActive(false);
        }
    }
}
