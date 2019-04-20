using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class Bouee : MonoBehaviour
{
    public float delai = 1f;

    bool rotationActivee = true;
    public float uneVariable = 50.0f; 


    // Start is called before the first frame update
    void Start()
    {
        // Pour la partie rotation 
        StartCoroutine(oscilation());
    } 

    IEnumerator oscilation()
    {
        while (rotationActivee)
        {
            yield return new WaitForSeconds(delai);
            transform.Rotate(Vector3.back * uneVariable * Time.deltaTime);
        }
    }

}


