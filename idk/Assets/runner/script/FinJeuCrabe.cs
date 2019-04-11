using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Math;


public class FinJeuCrabe : MonoBehaviour
{
    public static bool endGame;
    public GameObject FinJeu;
    public Text EndGameCrabe;
    public Text BestScore;


    void Start()
    {
        endGame = false;
    }

    void Update()
    {
        if (endGame)
        {
            Time.timeScale = 0;
            spawn.activ = false;
            FinJeu.SetActive(true);
            EndGameCrabe.text = System.Math.Truncate(TimerCrabe.targetTime).ToString();
            BestScore.text = "Best Score : " + TimerCrabe.inText;
        }

    }
}
