using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

// NOTE : Il y a de grandes chances pour que la force de flotaison soit inutile.  

public class Bouee : MonoBehaviour
{
    public float delai = 1f;
   
    /*
    bool danse = false;

    public float declechement = 1;
    private float countdown = 2f;

    public int force = 50;
    */

    bool rotationActivee = true;
    public float uneVariable = 50.0f; 


    // Start is called before the first frame update
    void Start()
    {
        // Pour la partie haut/bas
        //StartCoroutine(buoyancySimulation());

        // Pour la partie rotation 
        StartCoroutine(oscilation());
    } 

    /*
    IEnumerator buoyancySimulation()
    {
        while (danse)
        {
            yield return new WaitForSeconds(delai);
            GetComponent
            <Rigidbody>().AddForce(Vector2.up * force);
        }
    }
    */

    IEnumerator oscilation()
    {
        while (rotationActivee)
        {
            yield return new WaitForSeconds(delai);
            transform.Rotate(Vector3.back * uneVariable * Time.deltaTime);
        }
    }


    // Update is called once per frame
    void Update()
    {
        /* if(Time.deltaTime == declechement)
        {
            danse = true;
        } */
    }
}


