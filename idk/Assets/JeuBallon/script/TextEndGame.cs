using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextEndGame : MonoBehaviour
{
    public Text EndGame;
    public Text BestScore;

    void Update()
    {
        EndGame.text =  ScoreManager.score.ToString();
        BestScore.text = "Best Score : " + ScoreManager.inText;
    }
}
