using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jeu : MonoBehaviour
{
    private int NbPorteTotale { get; set; }
    private int NbPorteFranchie;

    Checkpoint[] TabCheckpoints = new Checkpoint[7];

    // Start is called before the first frame update
    void Start()
    {
        NbPorteFranchie = 0;  
    }

    // Update is called once per frame
    void Update()
    {
        
        int tempNbPorteFranchie = 0;
        foreach (Checkpoint c in TabCheckpoints)
        {
            if (c.EstFranchie == true)
            {
                tempNbPorteFranchie++;
            }
        }
        NbPorteFranchie = tempNbPorteFranchie;
        Debug.Log(" Le nombre de porte franchie est : " + tempNbPorteFranchie);

    }

public void SetNbPorteTotale( int newNbPorteTotale) { this.NbPorteTotale = newNbPorteTotale; }
     public void SetNbPorteFranchie() { this.NbPorteFranchie ++ ; }
}

