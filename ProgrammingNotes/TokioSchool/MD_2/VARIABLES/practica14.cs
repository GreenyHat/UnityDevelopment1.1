using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practica14 : MonoBehaviour
{
    float varClass0 = 13.3f;    /*recordemos que variables de clase se diferencia de 
    las de metodo por la posición en la que se declaran*/
    float varClass1 = 2.2f;
    float varClass2 = 4.5f;
    float varClass3 = 3f;
    float varClass4 = 3.2f;
    float varClass5 = 4.2f;
    float mediaAritmetica;
    // Start is called before the first frame update
    void Start()
    {
        mediaAritmetica= (varClass0+varClass1+varClass2+varClass3+varClass4+varClass5)/5;
        Debug.Log("Esta sería la media "+ mediaAritmetica);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
