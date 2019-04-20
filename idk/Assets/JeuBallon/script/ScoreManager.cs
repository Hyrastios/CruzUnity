using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public static int score;
    public static string inText;

    [SerializeField]
    private Text Score;    // Reference to the Text component.


    void Start()
    {
        // Set up the reference.
        //Score = GetComponent<Text>();

        // Reset the score.
        score = 0;
    }

    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        Score.text = score.ToString();

        if (PointDeVie.finPartie)
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
