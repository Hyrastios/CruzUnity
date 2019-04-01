using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeu : MonoBehaviour
{
    private int NbPorteTotale { get; set; }
    private int NbPorteFranchie;

    Porte[] TabPorte = new Porte[8];

    // Start is called before the first frame update
    void Start()
    {
        NbPorteFranchie = 0;  
    }

    // Update is called once per frame
    void Update()
    {

    }

     public void SetNbPorteTotale( int newNbPorteTotale) { this.NbPorteTotale = newNbPorteTotale; }
     public void SetNbPorteFranchie() { this.NbPorteFranchie ++ ; }
}

