using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Math;
using System.IO;

//Contrôle le timer dans le jeu Crabe + le meilleur score

public class TimerCrabe : MonoBehaviour
{
    public Text texttime;
    public static string inText;

    public static double targetTime;

    void Start()
    {
        targetTime = 0.0f;
    }

    void Update()
    {
        targetTime += Time.deltaTime;
        texttime.text = System.Math.Truncate(targetTime).ToString();

        if (FinJeuCrabe.endGame) //Si la partie est finie est que le score du joueur est > au meilleur score alors on le remplace dans le fichier ScoreCrabe
        {
            inText = System.IO.File.ReadAllText("Assets/runner/script/ScoreCrabe.txt");
            if (int.Parse(inText) < System.Math.Truncate(targetTime))
            {
                inText = System.Math.Truncate(targetTime).ToString();
                string outText = System.Math.Truncate(targetTime).ToString();
                System.IO.File.WriteAllText("Assets/runner/script/ScoreCrabe.txt", outText);
            }
      
        }
    }
}
