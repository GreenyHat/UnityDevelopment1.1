using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomMoce2 : MonoBehaviour
{

    /// <summary>
    /// Algo así en el ejercicio 6, poniendo un comienzo random en el update y un booleano
    /// para que se detenga tras llegar al punto no visible de la cámara?? No SÉ...
    /// espero una explicacion de este ejercicio por favor, me ha dado muchos dolores de cabeza.
    /// </summary>




    /*public float speed;
    bool canSee = true;
    public Camera cam;
    public float xPoint;
    public float yPoint;
    float limitY;
    Vector3 xVector;*/

    public float limitY;
 
    public float limitX;
   
    public bool firstMove;
    public float movingX;
    void Start()
    {
       
        firstMove = true;
        limitY = 8.545f;
        limitX=1.449F;

        
   


        /*        cam = Camera.main;
        */
    }

    void Update()
    {
        movingX = transform.position.x;


        transform.Translate(Vector3.left * Random.Range(-1f, -1.7f) * Time.deltaTime);

    }

    void moveX()
    {
        if (movingX<=9)
        {

        }
        if (limitX >= 8.279f && firstMove == false)
        {
            transform.Translate(Vector3.left  * Random.Range(1f,1.7f) * Time.deltaTime);
        }
    }

    private void OnBecameInvisible()
    {
        if (true)
        {

        }
    }



    /* private void OnBecameVisible()
     {
        transform.Translate(xVector * speed * Time.deltaTime);
        canSee = false;
     }*/

    //xPoint = cam.WorldToScreenPoint(new Vector3(2.4f, 4.45f));

}


    

