using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class JeuBallon : MonoBehaviour
{
    public GameObject jeuball;
    public static bool newjeuball = false;
    // Update is called once per frame
    void Update()
    {
        if (jeuball.activeInHierarchy)
        {
            newjeuball = true;
            SceneManager.LoadScene("Scenes/JeuBallon");
        }
    }
}
