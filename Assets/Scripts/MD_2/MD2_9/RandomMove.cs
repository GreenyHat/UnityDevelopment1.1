using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{
    public bool canLeft, canUp;
    public float speed=20f;
  

    private void Start()
    {
        
        RandomBegin();
    }

    private void Update()
    {
       
        XvectorManager();
        YvectorManager();
    }




    public void XvectorManager()
    {
        /* APUNTE MENTAL:
         * Te estas moviendo por deltatime,
         * por lo que el valor depende del tiempo por frame, 
         * por lo que los movimientos no son exactos, asi que no tienes por que estar justo en el 5.3
         * POR ESO NO FUNCIONABA CON EL X==5.4F
                                                */
        if (transform.position.x >= 5.4f)
        {
            canLeft = true;
        }
        if (transform.position.x <= -5.24f)
        {
            canLeft = false;
        }


        if (!canLeft)
        {
            if (transform.position.x < 5.4f)
            {
                transform.Translate(0.12f * Time.deltaTime * speed, 0, 0);
            }


        }

        else
        {
            transform.Translate(-0.12f * Time.deltaTime * speed, 0, 0);

        }



      


        
    }
    public void YvectorManager()
    {

        if (transform.position.y >= 2.05f)
        {
            canUp = true;
        }
        if (transform.position.y <= -2.24f)
        {
            canUp = false;
        }

        if (!canUp)
        {
            if (transform.position.y < 2.15f)
            {
               transform.Translate(0, 0.12f * Time.deltaTime * speed, 0);
            }


        }

        else
        {
            transform.Translate(0, -0.12f * Time.deltaTime * speed, 0);

        }

       
                


        
    }
    public void RandomBegin()
    {
        transform.Translate(Random.RandomRange(-4f, 4f), Random.RandomRange(2f, 2.15f), 0);
    }

    private void OnTriggerEnter(Collider other)//TRATA DE COMPRENDER QUE HAS HECHO AQUÍ!!!
    {
        Debug.Log("Hello Not Trigger");
        if (canLeft == true)
        {
            canLeft = false;
        }
        if (canUp == true)
        {
            canUp = false;
        }
       

    }
/*PARA EL EJERCICIO 8 TIENES QUE PONER ESTE SCRIPT EN UN GAMEOBJECT Y EL RANDOMMOVETRIGGER EN OTRO QUE SEA TRIGGER*/


    /*VECTOR SCREEN LIMIT:
     * x 5.433f
     *-x-5.24f
     * y 2.092f
     *-y-2.224 */
}

   

