using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Lance la scène "menu" dans unity

public class Retourmenu : MonoBehaviour
{
    public GameObject RetMenu;

    void Update()
    {
        if (RetMenu.activeInHierarchy)
            SceneManager.LoadScene("Scenes/menu");
    }
}
