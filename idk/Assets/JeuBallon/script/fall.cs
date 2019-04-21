using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Contrôle la vitesse de chute des ballons

public class fall : MonoBehaviour {

    private Rigidbody rBody;
    private float speed =3f;

    private void Start()
    {
        rBody = GetComponent < Rigidbody >();
    }
    void Update()
    {
        rBody.velocity = speed * rBody.velocity.normalized;
        speed += 1f;
    }
}
