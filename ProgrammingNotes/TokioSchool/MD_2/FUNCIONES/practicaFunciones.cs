using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
    
    ///////////////////////////////////////////
    ////////////////EJERCICIO 1///////////////
    /////////////////////////////////////////
    ////////////////////////////////////////
    
    
    void saludounity(){
    
    Debug.Log("Hola, estoy aprendiendo programacion");


    }


   
    void Start()
  {
         

     saludounity();




}*/
    ///////////////////////////////////////////
    ////////////////EJERCICIO 2///////////////
    /////////////////////////////////////////
    ////////////////////////////////////////

/*string saludoUnity(string myName="Toni")
{

    string saludoResult= "Hola, soy "+ myName+ " y he venido a estudiar programacion";
    return saludoResult;

}

    
   


       



    
   


    

void Start() { 
    
    


    }


void Update()
{
 
  Debug.Log(saludoUnity());




    ///////////////////////////////////////////
    ////////////////EJERCICIO 3///////////////
    /////////////////////////////////////////
    ////////////////////////////////////////



float testSum(float x=2.3f,float y=3.4f,float z=5.7f,float g=8.9f,float r=9.9f)
    {
        float sumElem=x+y+z+g+r;return sumElem;
         
    }


void Start()
{
   Debug.Log("El resultado de la suma es: "+testSum()); 
    





}

    ///////////////////////////////////////////
    ////////////////EJERCICIO 4///////////////
    /////////////////////////////////////////
    ////////////////////////////////////////


 float[] cadenaNumeros = {2.3f, 4.5f , 6.7f, 3.5f, 6.4f};
     float testSumaArray(){
        float media=cadenaNumeros[0] + cadenaNumeros[1] + cadenaNumeros[2] + cadenaNumeros[3] + cadenaNumeros[4];
        media=media/5;return media;

      }

   


 void Start() 
{
    Debug.Log("El resultado de la media es: "+ testSumaArray());
    
}

 void Update()
 {
     
 }



}*/



    ///////////////////////////////////////////
    ////////////////EJERCICIO 5///////////////
    /////////////////////////////////////////
    ////////////////////////////////////////


    /*En este ejercicio las variables a modificar son públicas así que se pueden cambiar desde el
    editor para hacer pruebas :)
    public int n;
    public int m;
   






/// Start is called on the frame when a script is enabled just before
/// any of the Update methods is called the first time.

void Start()
{
    
    Debug.Log(4%2);//para comprobaciones
  
calculoDivisor(m,n);
 
 if (m%n==0)
 {
     Debug.Log("Sí, "+ n+ " es divisor de "+ m);
     
 }
 else
 {
     Debug.Log("Va a ser que no...");
 }

}


/// Update is called every frame, if the MonoBehaviour is enabled.

void Update()
{

}

int calculoDivisor(int n,int m)
{
    int resultado = m/n;return resultado;
}
*/

public class practicaFunciones : MonoBehaviour
{
    int b=6;
    int [] arrayDivisores = {2,5,6,7};
    

 void Start() {

    funcionDivisorArrays();
    if (funcionDivisorArrays()==0)//Por que no puedo poner resultado sin mas, es decir el return¿?
    {
      Debug.Log("prueba");
    }
    
}





 void Update() {

}

int funcionDivisorArrays()//3 factores --> array de 4 numeros y el numero b(todos enteros)
{
    int resultado=b%arrayDivisores;return resultado;
}




   


}



