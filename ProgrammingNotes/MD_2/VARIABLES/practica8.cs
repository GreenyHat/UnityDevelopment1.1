using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practica8 : MonoBehaviour
{
    public int numero1 = 3;
    public int numero2 = 6;
    public int numero3;


    // Start is called before the first frame update
    void Start()
    {
       
        numero3 = (numero1+numero2);
        Debug.Log("El resultado es "+ numero3);

    }

    

    // Update is called once per frame
    void Update()
    { 
        
    }
}
