    /////////////////////////////////////o///////////////////////////////////
    /////////////////////////////////////o//////////////////////////////////
    ///////////////////////////////Ejercicio 10////////////////////////////
    /////////////////////////////////////o////////////////////////////////
    /////////////////////////////////////o///////////////////////////////


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicios13Al18 : MonoBehaviour
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
        
        
        /*Debug.Log(arrayCadenaDeCaracteres[0] + "\r\n" + arrayCadenaDeCaracteres[1] + "\r\n" + arrayCadenaDeCaracteres[2] + "\r\n" + arrayCadenaDeCaracteres[3] + "\r\n" + arrayCadenaDeCaracteres[4] );
        Debug.Log(arrayDecimales[0]+arrayDecimales[1]+arrayDecimales[2]+arrayDecimales[3]+arrayDecimales[4]);
        Debug.Log("La media es "+(arrayEnteros1[0]+arrayEnteros1[1]+arrayEnteros1[2]+arrayEnteros1[3]+ arrayEnteros1[4])/5);//ejercicio 15
        */
      


        


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

    Debug.Log(arrayEnteros18[0]=arrayEnteros18[0]+2);
    Debug.Log(arrayEnteros18[1]=arrayEnteros18[1]*2);
    Debug.Log(arrayEnteros18[2]=arrayEnteros18[2]*3);
    Debug.Log(arrayEnteros18[3]=arrayEnteros18[3]+arrayEnteros18[0]);

    
 /*una pregunta, en el ejercicio 18, que es este último ejercicio tiene una errata o es que hago algo mal¿? Porue cuando se su pone que me debe dar 7
 me da nueve, porque si sumo el primer indice (el cual se va incrementando en 2) va a dar: 1+2 --> 3+1 y despues 3+2 --> 5+4; es decir: 
 4 y 9 y no 4 y 7 como plantea el ejercicio. Dónde está el error¿?  */
 

      
  
    }
}
