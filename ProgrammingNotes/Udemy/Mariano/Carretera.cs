using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carretera : MonoBehaviour
{
    Coche miCoche;
    // Start is called before the first frame update
    void Start()
    {
        CrearCoche();
        ApagarMotores();
    }

    void CrearCoche()
    {
        miCoche = new Coche(); //el objeto miCoche esta dentro de la raza Coche, es un derivado de el. Por eso ponemos el objeto X es un (X=new objectX) nuevo coche()
        /*Esta operacion tambien la podria realizar con otra clase que hubiese creado dentro de la misma solucion/proyecto. Por ejemplo digamos que tenemos una clase llamada Llanta.cs,
         * pues aquí mismo, en la zona de las variables de clase podria declararala e inicializarla al mismo tiempo.La sintaxis sería la siguiente:
         * public Llanta llanta [o cualquier otro nombre] = new Llanta();
         */

        miCoche.marca = "Audi";//con el punto estoy accediendo a las PROPIEDADES que tiene el objeto miCoche (que esta dentro de la raza Coche, es un derivado de el)
        miCoche.numeroPuertas = 4;
        miCoche.numeroRuedas = 4;
        miCoche.MotorEncendido();
        print("mi coche es de la marca " + miCoche.marca + " tiene " + miCoche.numeroPuertas + " puertas y " + miCoche.numeroRuedas + " ruedas.");
            
    }
   void ApagarMotores()
    {
        miCoche.MotorApagado();
    }



}
