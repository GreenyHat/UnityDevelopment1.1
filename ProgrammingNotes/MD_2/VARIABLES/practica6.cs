using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practica6 : MonoBehaviour
{ 
    
    public string myName;

    // Start is called before the first frame update
    void Start()
    {
        myName= " Jose Manuel";

        Debug.Log ("Hola" +myName);

      /*En tiempo de ejecución aparece el nombre que está en el código, entiendo que porque ha sido inicializado, sin embargo si solo declaras
      y a continuacion pones el nombre desde el editor, sí que se ve modificado., pero los cambios en tiempo de ejecución de todos modos
      no se guardan.*/


    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
