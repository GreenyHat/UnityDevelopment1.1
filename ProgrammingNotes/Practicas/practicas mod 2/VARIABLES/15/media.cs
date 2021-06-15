using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class media : MonoBehaviour
{
    public float varClass0 = 13.3f;    /*recordemos que variables de clase se diferencia de 
    las de metodo por la posición en la que se declaran*/
    public float varClass1;
    public float varClass2;
    public float varClass3;
    public float varClass4;
    public float varClass5;
    public float varClass6;
    public float varClass7;
    public float mediaAritmetica;
    public int numeroValores;
    // Start is called before the first frame update
    void Start()
    {
        mediaAritmetica= (varClass0+varClass1+varClass2+varClass3+varClass4+varClass5)/numeroValores;
        Debug.Log("Esta sería la media "+ mediaAritmetica);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

