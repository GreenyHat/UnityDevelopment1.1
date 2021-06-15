using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptMovimiento : MonoBehaviour
{
   
    public float velocidad;

    void Update()
    {
        //Ejercicio 11.
        
        ////////////////////////////////////////////////////////////////////////////////////////////////

        if (transform.position.x <= 10)
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);//xk conflict
        }


        else if (transform.position.x == 10|| transform.position.y <= 10)
        {
            transform.Translate(Vector3.up * velocidad * Time.deltaTime);
        }

        

        else if (transform.position.x > 0 || transform.position.y == 9)
        {
            transform.Translate(Vector3.left*velocidad*Time.deltaTime);
        }


    }   }


