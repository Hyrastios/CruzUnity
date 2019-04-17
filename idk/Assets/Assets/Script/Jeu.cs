using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Math;

public class Jeu : MonoBehaviour
{
    private int NbPorteTotale { get; set; }
    public static int NbPorteFranchie { get; set; }

    public static bool endGame;
    public static bool victoire;
    public GameObject FinJeu;
    public Text TexteDeFin;
    public Text TexteDeFin2;
    public Text TexteDeFin3;
    public Text TexteDeFin4;

    public Text texttime;
    
    // Start is called before the first frame update
    void Start()
    {
        NbPorteTotale = 7;
        NbPorteFranchie = 0;
        endGame = false;
        victoire = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!endGame)
        {
            texttime.text = NbPorteFranchie.ToString() + " / " + NbPorteTotale;
        }
        else 
        {
            Time.timeScale = 0;
            FinJeu.SetActive(true);

            if (victoire)
            {
                TexteDeFin.text = "Votre temps pour franchir";
                TexteDeFin2.text = "franchir les ";
                TexteDeFin3.text = "7 portes est";
                TexteDeFin4.text = " de : " + System.Math.Truncate(TimerCrabe.targetTime).ToString() + " secondes";
            }
            else
            {
                TexteDeFin3.text = "Vous avez";
                TexteDeFin4.text = "perdu.";
            }
        }
        if (NbPorteFranchie == NbPorteTotale)
        {
            victoire = true;
            endGame = true;
        }

    }

    public void SetNbPorteTotale( int newNbPorteTotale) { this.NbPorteTotale = newNbPorteTotale; }
    // public void SetNbPorteFranchie() => this.NbPorteFranchie++;


}



