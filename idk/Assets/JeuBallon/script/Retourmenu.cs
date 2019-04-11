using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retourmenu : MonoBehaviour
{
    public GameObject RetMenu;

    // Update is called once per frame
    void Update()
    {
        if (RetMenu.activeInHierarchy)
            SceneManager.LoadScene("Scenes/menu");
    }
}
