using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlObjeto : MonoBehaviour
{
    /// <summary>
    ///PRACTICA 14 ///
    /// </summary>


    public float velocidad;
    public GameObject cubo;
    public ControlObjeto stop;
    /*En cuanto a la pregunta de si tiene sentido quitar o no el Script para luego activarlo de nuevo
     la respuesta que he encontrado es que lo que podrias hacer es lo que he hecho.
    inicializar una variable del tipo Script de la clase que tu has hecho, asignarle el componente
    Script que te interesa detener y trabajar sobre la variable DESDE el Script. Lo mismo
     se podría hacer desde otro Script, por ejemplo (pero no sabía como conectar
    la variable velocidad, para poder trabajar bien los condicionales.)*/

    void Start()
    {
        velocidad = 100;
        stop = GameObject.Find("Cube").GetComponent<ControlObjeto>();

    }

    // Update is called once per frame
    void Update()
    {
        SpeedIncrement();//Para incrementar la velocidad


        if (transform.position.y <= 1 && transform.position.x > 6)
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
            
        }

        else if (transform.position.y < 9 && transform.position.x <= 7)
        {
            transform.Translate(Vector3.up * velocidad * Time.deltaTime);

        }

        else if (transform.position.y >= 9 && transform.position.x < 7)
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);

        }


        else if (transform.position.x > 6)
        {
            transform.Translate(Vector3.down * velocidad * Time.deltaTime);
        }

        if (velocidad == 300)
        {
            stop.enabled = false;
        }


    }

    



    void SpeedIncrement()
    {
        if (transform.position.y <= 1 && transform.position.x >= 5)
        {
            velocidad+=10;
        }

        
    }
}

