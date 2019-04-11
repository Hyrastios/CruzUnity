using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Math;
using System.IO;


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
      //  targetTime = System.Math.Truncate(targetTime);
        texttime.text = System.Math.Truncate(targetTime).ToString();

        if (FinJeuCrabe.endGame)
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
