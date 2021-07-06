using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMonoBehaviour1 : MonoBehaviour
{
    private void Awake()
    {
        print("Soy awake");//Se ejecuta primero
    } 
    private void Start()
    {
        print("Soy Start"); //Se ejecuta tercero

    }
    private void OnEnable()
    {
        print("Soy OnEnabled");//Se ejecuta segundo
    }

    private void OnDisable()
    {
        print("probando disable");
    }

    private void OnDestroy()
    {
        print("probando destroy");
    }
    //Ejercicio 9: Si lo desactivamos en tiempo de ejecucion no pasa nada, si luego activamos de nuevo el GO 
    //salta el evento OnEnabled. Si lo desactivamos y luego ejecutamos no se ejecutará nada, pero si luego en tiempo de ejecucion
    //volvemos a activar el gO se ejecuta el evento OnEnable

}
