using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Math;


public class TimerCrabe : MonoBehaviour
{
    public Text texttime;

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
    }
}
