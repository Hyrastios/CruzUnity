using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    Scene scene;  
    public GameObject newg;
    private void Start()
    {
        scene = SceneManager.GetActiveScene();
    }
    // Update is called once per frame
    void Update()
    {
        if (JeuBallon.newjeuball)
        {
            SceneManager.LoadScene(scene.buildIndex);
            JeuBallon.newjeuball = false;
        }
        if (newg.activeInHierarchy)
        {
            SceneManager.LoadScene(scene.buildIndex);
            newg.SetActive(false);
        }
    }
}
