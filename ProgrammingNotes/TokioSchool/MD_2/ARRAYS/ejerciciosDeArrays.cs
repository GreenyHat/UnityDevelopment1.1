    /*public float[] puntuacionesMaximas;

    float[] puntuacionesMaximas2 = new float[12];

    /////////////////////////////////////o///////////////////////////////////
    /////////////////////////////////////o//////////////////////////////////
    /////////////////////////////// Ejercicios ////////////////////////////
    /////////////////////////////////////o////////////////////////////////
    /////////////////////////////////////o///////////////////////////////
    

    /*En respuesta al ejercicio 2 cuando escribimos un numero 
    en size, se convierte en el número de indices del array, siguiendo con
    el ejercicio 3 se identifica el primero como 0
    y eñ ultimo como 12 (13-1, ya que el primer elemento
    para el programa es 0). En cuanto al ejercicio 4, si meto una letra
    me devuelve al 0, pero si meto un numero entero aparentemente no
    pasa nada, en cuanto al ejercicio 6 tampoco observo nada que sea
    significativo aparentemente, al activar el modo ejecucion tampoco aparece nada.
    


/// Start is called on the frame when a script is enabled just before
/// any of the Update methods is called the first time.

void Start()
{
    

float[] puntuacionesMaximas2 = {34.5f,4.6f,4.5f,4.9f,92.3f,34.5f,4.6f,4.5f,9.5f,92.3f,34.5f,4.63f};

    
}

*/





using UnityEngine;

class ejerciciosDeArrays : MonoBehaviour {

    /////////////////////////////////////o///////////////////////////////////
    /////////////////////////////////////o//////////////////////////////////
    /////////////////////////////// Ejercicio 9////////////////////////////
    /////////////////////////////////////o////////////////////////////////
    /////////////////////////////////////o///////////////////////////////
    public float[] arrayDecimales = {3.4f,3.6f,6.7f,5.6f,6.6f};
    public string[] arrayCadenaDeCaracteres={"Julia","Julio","Julian","Alberto","Sofia"};
    
    public bool[] arrayBooleanos={true,false,false&&true,true||false,false||true};
    //No tengo claro si estas expresiones tienen sentido.
    public int [] arrayEnteros1={2,3,4,5,6};
    public int [] arrayEnteros2={1,0,3,6,9};

    /* Lo que observamos es que al editar desde vs code no se alteran los datos
    pero cuando removemos el script y lo añadimos de nuevo los valores 
    se escriben tan y como los programamos*/



/// <summary>
/// Start is called on the frame when a script is enabled just before
/// any of the Update methods is called the first time.
/// </summary>
void Start()
{
    
}



/// Update is called every frame, if the MonoBehaviour is enabled.

void Update()
{
    
    
}



    
}

    /////////////////////////////////////o///////////////////////////////////
    /////////////////////////////////////o//////////////////////////////////
    ///////////////////////////////Ejercicio 10////////////////////////////
    /////////////////////////////////////o////////////////////////////////
    /////////////////////////////////////o///////////////////////////////


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio10 : MonoBehaviour
{
    public float[] arrayDecimales = {3.4f,3.6f,6.7f,5.6f,6.6f};
    public string[] arrayCadenaDeCaracteres={"Claudio","Maria","Julian","Alberto","Sofia"};
    
    public bool[] arrayBooleanos={true,false,false&&true,true||false,false||true};
    //No tengo claro si estas expresiones tienen sentido.
    public int [] arrayEnteros1={2,3,4,5,6};
    public int [] arrayEnteros2={1,0,3,6,9};
    public int [] arrayEnteros18={1,1,1,1};
    


    // Start is called before the first frame update
    void Start()
    {
        
        /*arrayEnteros1=arrayEnteros2;*/ //ejercicio 13

        //arrayEnteros1[1]=arrayEnteros2[4];//ejercicio 14.
        
        
        Debug.Log(arrayCadenaDeCaracteres[0] + "\r\n" + arrayCadenaDeCaracteres[1] + "\r\n" + arrayCadenaDeCaracteres[2] + "\r\n" + arrayCadenaDeCaracteres[3] + "\r\n" + arrayCadenaDeCaracteres[4] );
        Debug.Log(arrayDecimales[0]+arrayDecimales[1]+arrayDecimales[2]+arrayDecimales[3]+arrayDecimales[4]);
        Debug.Log("La media es "+(arrayEnteros1[0]+arrayEnteros1[1]+arrayEnteros1[2]+arrayEnteros1[3]+ arrayEnteros1[4])/5);//ejercicio 15
      


        


    } 

    // Update is called once per frame
    void Update()
    {
    /*Debug.Log(arrayEnteros1[0] = arrayEnteros1[0]+1);
    Debug.Log(arrayEnteros1[1] = arrayEnteros1[1]+2);
    Debug.Log(arrayEnteros1[2] = arrayEnteros1[2]+3);  
    Debug.Log(arrayEnteros1[3] = arrayEnteros1[3]+4);
    Debug.Log(arrayEnteros1[4] = arrayEnteros1[4]+5);  
    Ejercicico 16.
    Ej 17: lo que ocurre es que se va ejecutando el codigo frame a frame.*/