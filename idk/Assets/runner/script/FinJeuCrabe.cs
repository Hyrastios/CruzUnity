using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Math;

//Losrque la partie est finie le bollean endGame devient true 

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
        //Si endGame = true alors on arrete la partie et on affiche le menu de fin de partie ainsi que le meilleur score
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
