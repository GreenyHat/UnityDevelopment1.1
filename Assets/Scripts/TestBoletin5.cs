using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBoletin5 : MonoBehaviour

{
    
    private GameObject Cube; // He arrastrado al cubo  desde Hierarchy hasta el Inspector. (respecto al ej 2)
    
    private void Awake()
    {
        Cube = GameObject.FindGameObjectWithTag("Player");
        transform.localScale = Cube.transform.localScale = new Vector3(2, 2, 2);


    }
    // Start is called before the first frame update
    void Start()
    {






        
        /*
             /////////////////
            /////////////////
           ///Ejercicio1////
          /////////////////
         /////////////////

         Transform trC = GetComponent<Transform>();
    
         trC.localScale=new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z)*2f;




             /////////////////
            /////////////////
           ///Ejercicio2////
          /////////////////
         /////////////////


              transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z)*2f;



             /////////////////
            /////////////////
           ///Ejercicio3////
          /////////////////
         /////////////////



                      /////////////////
            /////////////////
           ///Ejercicio1////
          /////////////////
         /////////////////

         
                      /////////////////
            /////////////////
           ///Ejercicio1////
          /////////////////
         /////////////////
         
         
         
                      /////////////////
            /////////////////
           ///Ejercicio1////
          /////////////////
         /////////////////
          
          
                      /////////////////
            /////////////////
           ///Ejercicio1////
          /////////////////
         /////////////////
          
          
          
                      /////////////////
            /////////////////
           ///Ejercicio1////
          /////////////////
         /////////////////
          
          
          
                      /////////////////
            /////////////////
           ///Ejercicio1////
          /////////////////
         /////////////////
          
          
                      /////////////////
            /////////////////
           ///Ejercicio1////
          /////////////////
         /////////////////
          
          
                      /////////////////
            /////////////////
           ///Ejercicio1////
          /////////////////
         /////////////////
          
          
                      /////////////////
            /////////////////
           ///Ejercicio1////
          /////////////////
         /////////////////
           
           
                      /////////////////
            /////////////////
           ///Ejercicio1////
          /////////////////
         /////////////////
         
         
                      /////////////////
            /////////////////
           ///Ejercicio1////
          /////////////////
         /////////////////
          
          
          
                      /////////////////
            /////////////////
           ///Ejercicio1////
          /////////////////
         /////////////////   










     */






    }




}

