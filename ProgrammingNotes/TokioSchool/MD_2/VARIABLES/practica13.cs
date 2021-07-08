using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practica13 : MonoBehaviour
{
    int valor1=1000;
    
    
 
     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        valor1-=2;//IMPORTANTE: <-- = valor1=valor1-2
        Debug.Log(valor1);

        
    }
}
