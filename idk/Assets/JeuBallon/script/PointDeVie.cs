using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

//Contrôle les points de vie du joueur pour le jeu ballon 

public class PointDeVie : MonoBehaviour
{
    public static int NbPv;
    public static int PV;
    
    public static bool finPartie;

    public GameObject pdv;
    public Text textPV;
    public GameObject End;
    public GameObject pv1;
    public GameObject pv2;
    public GameObject pv3;

    void Awake()
    {
        NbPv = 3;
        PV = 3;
        finPartie = false;
    }

    private void Start()
    {
        NbPv = 3;
        PV = 3;
        finPartie = false;
    }

    void Update()
    {
        NbPv = PV - killZone.nbkill;
        textPV.text = NbPv.ToString() + " PV";

        if(NbPv == 2)
        {
            if (pv3.activeInHierarchy)
                pv3.SetActive(false);
        }
        if (NbPv == 1)
        {
            if (pv2.activeInHierarchy)
                pv2.SetActive(false);
        }

        if (NbPv == 0)
        {
            pv1.SetActive(false);
            Time.timeScale = 0;
            WaveSpawner.isActive = false;
            finPartie = true;
            pdv.SetActive(false);
            End.SetActive(true);
            
        }
    }
}
