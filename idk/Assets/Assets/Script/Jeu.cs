using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jeu : MonoBehaviour
{
    private int NbPorteTotale { get; set; }
    public static int NbPorteFranchie { get; set; }

    public Text texttime;
    
    // Start is called before the first frame update
    void Start()
    {
        NbPorteTotale = 7;
        NbPorteFranchie = 0;  
    }

    // Update is called once per frame
    void Update()
    {
        texttime.text = NbPorteFranchie.ToString() + " / " + NbPorteTotale ;
    }

    public void SetNbPorteTotale( int newNbPorteTotale) { this.NbPorteTotale = newNbPorteTotale; }
    // public void SetNbPorteFranchie() => this.NbPorteFranchie++;
}

