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


   

    public float speed;
    bool canSee = true;
    public Camera cam;
    public float xPoint;
    float limitX;
    float limitY;

    void Start()
    {
        limitY = gameObject.transform.position.y;
        cam = Camera.main;
    }

    void Update()
    {
        //xPoint = cam.WorldToScreenPoint(new Vector3(2.4f, 4.45f));
    }

    private void OnBecameVisible()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        canSee = false;
    }



    
        //if (canSee == false)
        //{
        //   transform.Translate(Vector3.left* speed * Time.deltaTime);

}


    

