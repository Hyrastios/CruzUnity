using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public static int score;
    public static string inText;

    [SerializeField]
    private Text Score;    


    void Start()
    {
        score = 0;
    }

    void Update()
    {
        Score.text = score.ToString();

        if (PointDeVie.finPartie) //Change le meilleur score dans ScoreBallon si le score du joueur est > au meilleur score 
        {
            Score.text = " ";
            
            inText = System.IO.File.ReadAllText("Assets/JeuBallon/script/ScoreBallon.txt");
            if (int.Parse(inText) < score)
            {
                inText = score.ToString();
                string outText = score.ToString();
                System.IO.File.WriteAllText("Assets/JeuBallon/script/ScoreBallon.txt", outText);
            }
        }
    }

    public int GetScore()
    {
        return score;
    }
}
