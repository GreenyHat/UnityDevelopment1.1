using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practica7 : MonoBehaviour

{
    public int numeroEntero;
    public float numeroDec;
    public string cadenaTxt;
    public bool esPrueba;



    // Start is called before the first frame update
    void Start()
    {
        numeroEntero = 2;
        numeroDec = 0.5f;
        cadenaTxt = " Hola Jose";
        

        
            Debug.Log (cadenaTxt+  " Aquí un decimal --> " + numeroDec+ " y aquí el entero --> " +numeroEntero  + esPrueba);



             //Esta no es la mejor solucion... :S
            Debug.Log(cadenaTxt);
            Debug.Log(numeroDec);
            Debug.Log(numeroEntero);
            Debug.Log(esPrueba);
            
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
