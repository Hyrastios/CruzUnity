using System;
using UnityEngine;

public class Fly : MonoBehaviour
{
    private readonly int maxSpeed = 50;
    private string accelKey = "w";      // Touche utilisée pour l'accélération
    private string decelKey = "x";      // Touche utilisée pour freiner
    private string leftKey = "left";    // Commande de vol
    private string rightKey = "right";  // Commande de vol
    //private string upKey = "up";      // Commande de vol
    //private string downKey = "down    // Commande de vol
    private readonly float accel = 1.2f;  // Coef. d'accel. 1 < accel < infini
    private float decel = 0.8f;          // Coef. de freinage. 0 < decel < 1
    private float upDownSpeed = 20.0f;
    private float turnSpeed = 20.0f;
    private float speedToFly = 40.0f;
    private int curSpeed;       // Vitesse actuelle
    private float curFall;
    private bool isFalling = false;
    static bool isGrounded = true;
    private bool isFlying = true;

    private void Start()
    {
        curSpeed = 41; // Car la vitesse nécessaire pour voler est de 40
        curFall = 0;

    }


    private void Update()
    {
        while (isFlying == true)
        {
            // Controle de vitesse
            if ((Input.GetKey(accelKey) || Input.GetKeyDown(accelKey)) && maxSpeed == (curSpeed))
            {
                curSpeed += 0;
            }
            if (Input.GetKeyDown(accelKey) && maxSpeed > curSpeed)
            {
                curSpeed++;
            }
            if (Input.GetKey(accelKey) && maxSpeed > curSpeed)
            {
                float tmpSpeed = accel * Time.deltaTime;
                curSpeed += (int)tmpSpeed;
            }
            if (Input.GetKeyDown(decelKey) && curSpeed > 0)
            {
                curSpeed--;
            }
            if (Input.GetKey(decelKey) && curSpeed > 0)
            {
                float tmpSpeed = 2 * decel * Time.deltaTime;
                curSpeed -= (int)tmpSpeed;
            } // Si il freine on accentue le freinage
            else
            {
                float tmpSpeed = decel * Time.deltaTime;
                curSpeed -= (int)tmpSpeed;
            }

            // Altitude
            if ((curSpeed == 0))
            {
                curFall += (float)9.8 * Time.deltaTime;
                transform.Translate(Vector3.down * curFall * Time.deltaTime);

                // RESOUDRE LIGNE SUIVANTE 
                //transform.rotation.x(45);

                float y = transform.position.y;
                if (y == 48)

                {
                    isFlying = false;
                }
            }

            // Controle de direction
            // Plus de réalisme en orientant l'avion sur  Z également
            if (Input.GetKey(leftKey))
            {
                transform.Rotate(Vector3.up * (-1) * turnSpeed * Time.deltaTime);
            }
            if (Input.GetKey(rightKey)) 
            {
                transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
            }
        }
    }

}