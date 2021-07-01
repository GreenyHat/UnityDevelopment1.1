                             /*AQUÍ ESTÁN TODAS LAS PRÁCTICAS DE VARIABLES DEL MODULO 2 */ 


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
string strangerPhrase = ("Bahh, I don't care if you are not a machine, I love you.");
   
 Debug.Log ("Hello fucking world ^^ ");
 Debug.Log ("Ehh, Who at fuck are you?");
 Debug.Log ("Where are my hot bites?");
 Debug.Log (strangerPhrase);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

// ====================================================== //
// ====================================================== //
// ====================================================== //

public class HiMyName : MonoBehaviour
{ 

public string myName =("John Rambo");

    // Start is called before the first frame update
    void Start()
    {
        

        Debug.Log ("Hola" +myName);





    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}


// ====================================================== //
// ====================================================== //
// ====================================================== //

public class holamellamo : MonoBehaviour
{

    public string myName = " Antonio";

   
    // Start is called before the first frame update
    void Start()
    {

         Debug.Log("Hola" +myName);
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


// ====================================================== //
// ====================================================== //
// ====================================================== //


public class Clase4 : MonoBehaviour
{ 

public string myName;

    // Start is called before the first frame update
    void Start()
    {
        
     myName = " Jose Moyano";
        Debug.Log ("Hola" +myName);





    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}

// ====================================================== //
// ====================================================== //
// ====================================================== //


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

// ====================================================== //
// ====================================================== //
// ====================================================== //


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

// ====================================================== //
// ====================================================== //
// ====================================================== //


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


// ====================================================== //
// ====================================================== //
// ====================================================== //


public class pr9 : MonoBehaviour
{
    public int numero1 = 3;
    public int numero2 = 6;
    public int numero3;


    // Start is called before the first frame update
    void Start()
    {
        
        numero3 = (numero1+numero2);
        Debug.Log("El resultado es "+ numero3);

        //Pues efectivamente, como vimos antes, los cambios en tiempo de ejecución no se guardan y permanecen las asignaciones del código.

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


// ====================================================== //
// ====================================================== //
// ====================================================== //

public class media : MonoBehaviour
{
    public float varClass0 = 13.3f;    /*nota mental: variables de clase se diferencia de 
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


// ====================================================== //
// ====================================================== //
// ====================================================== //



public class practica10 : MonoBehaviour
{
    public int numero1;
    public int numero2;
    public int numero3;


    // Start is called before the first frame update
    void Start()
    {
       numero1=3;
       numero2=5;
        numero3 = (numero1+numero2);
        Debug.Log("El resultado es "+ numero3);

    }

    

    // Update is called once per frame
    void Update() {
        
    }

}  
    





// ====================================================== //
// ====================================================== //
// ====================================================== //



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




// ====================================================== //
// ====================================================== //
// ====================================================== //



public class practica12 : MonoBehaviour
{
    public int conteo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(conteo++);
        
    }
}




// ====================================================== //
// ====================================================== //
// ====================================================== //



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



// ====================================================== //
// ====================================================== //
// ====================================================== //



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




// ====================================================== //
// ====================================================== //
// ====================================================== //

public class practica16 : MonoBehaviour
{
    public int a=0;
    public int b=1;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
    
    

    }

    // Update is called once per frame
    void Update()
    {
        int temp; /*esto es una variable temporal para
        economizar espacio de memoria, se utiliza 
        una vez y desaparece la variable*/ 
        temp=a;
        a=b;
        b=temp+b;//sucesionDeFibonacci
               /*EXPLICACIÓN*/
        /*   a-0;b-1;[temp-a(1);a(temp)=b-1; b=temp(a)->1+b->b=temp(a)];   */
        
        Debug.Log(temp);

    
        
        Debug.Log(2+3)(srgf);
       

    } 
}


// ====================================================== //
// ====================================================== //
// ====================================================== //

public class practica17 : MonoBehaviour
{
    public float datoAEvaluar;
    float porcentaje25;
    float porcentaje50;
    float porcentaje75;
    // Start is called before the first frame update
    void Start()
    {
        porcentaje25= datoAEvaluar*0.25f;
        porcentaje50= datoAEvaluar*0.50f;
        porcentaje75= datoAEvaluar*0.75f;
       

         Debug.Log(porcentaje25 + " Es el 25% de " + datoAEvaluar + " el 50% " + porcentaje50 + " y este, el 75% --> " + porcentaje75 + " cuando llegue a 100 el PC colapsará :) " );
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
