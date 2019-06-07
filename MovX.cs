using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovX : MonoBehaviour
{
    float velocidad = 0.3f;
    int tope = 4;
    bool direccion;
    private int x;

    private void start()
    {
        direccion = true;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (direccion == true)
        {
            if (transform.position.x < tope)
            {
                transform.Translate(Vector3.right * velocidad);
            }
            if (transform.position.x >= tope)
            {
                direccion = false;
            }
        }
        if (direccion==false)
        {
            if (transform.position.y < 6)
            {
                transform.Translate(Vector3.up * velocidad);
                    
                    
            }
        }

        {
            if (direccion == true)
            {
                if (transform.position.y < tope)
                {
                    transform.Translate(Vector3.left * velocidad);
                }
                if (transform.position.y >= tope)
                {
                    direccion = false;
                }
            }
            if (direccion == false)
            {
                if (transform.position.x < 6)
                {
                    transform.Translate(Vector3.left * velocidad);


                }
            }

            {
                if (direccion == true)
                {
                    if (transform.position. x > tope)
                    {
                        transform.Translate(Vector3.right * velocidad);
                    }
                    if (transform.position. x <= tope)
                    {
                        direccion = false;
                    }
                }
                if (direccion == false)
                {
                    if (transform.position.y < -6)
                    {
                        transform.Translate(Vector3.down * velocidad);


                    }
                }

                if (direccion == true)
                {
                    if (transform.position. y > tope)
                    {
                        transform.Translate(Vector3.right * velocidad);
                    }
                    if (transform.position. y >= tope)
                    {
                        direccion = false;
                    }
                }
                if (direccion == false)
                {
                    if (transform.position.y > -6)
                    {
                        transform.Translate(Vector3.up * velocidad);


                    }
                }

            }

        }// fin update
}//fin clase
}







