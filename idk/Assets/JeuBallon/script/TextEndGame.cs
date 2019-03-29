using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextEndGame : MonoBehaviour
{
    public Text EndGame;

    void Update()
    {
        EndGame.text =  ScoreManager.score.ToString();
    }
}
