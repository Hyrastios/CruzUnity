using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Contrôle l'apparition aléatoire des crabes

public class spawn : MonoBehaviour
{
    public GameObject[] crab;

    private float TempsSpauwn;
    public float StartTempsSpawn;
    public static bool activ;

    void Start()
    {
        activ = true;
    }

    void Update()
    {
        if (activ)
        {
            if (TempsSpauwn <= 0)
            {
                int rand = Random.Range(0, crab.Length);
                Instantiate(crab[rand], transform.position, Quaternion.identity);
                TempsSpauwn = StartTempsSpawn;
            }
            else
            {
                TempsSpauwn -= Time.deltaTime;
            }
        }
    }
}
