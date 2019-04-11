using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public static int score;

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
            Score.text = " ";
     
    }

    public int GetScore()
    {
        return score;
    }
}
