using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBallon : MonoBehaviour
{
    public GameObject ball;

    public void OnCollisionEnter(Collision other)
    {
        Destroy(ball.gameObject);
        FinJeuCrabe.endGame = true;
    }


}
