using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practica11 : MonoBehaviour
{
    float valor1;
    float valor2;
    float valor3;
    public float sumaTotal;

    // Start is called before the first frame update
    void Start()
    {

        valor1=3.3f;
        valor2=4.7f;
        valor3=5.5f;
        

       Debug.Log( valor1);  /*apunte mental esto es para el salto de linea ES CON **"n\"** NO CON / */

       sumaTotal=valor1+valor2;


       Debug.Log(sumaTotal);

       sumaTotal=valor1+valor2+valor3;

       Debug.Log(sumaTotal);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
