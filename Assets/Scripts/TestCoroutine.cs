using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCoroutine : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(DestroyObject());//Aqui se puede poner o con cadena de caracteres o
        //a modo de funcion (es mas optima la segunda manera)
    }

    void Update()
    {
        
    }

     IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
    }


    //IEnumerator Es un retraso en la lectura del ciclo de MonoBehaviour. 
    //Tiene que tener un tipo de devuelto IEnumerator
    /*La ejecucion del codigo se repite UNA VEZ  cada numero de segundos que establezcamos
     *POR CADA RETRASO QUE PONGAMOS, osea cada yield return new WaitForSeconds
     ***SE PUEDE TRANSFORMAR EL START EN UNA CORRUTINA ASIGNANDOLE VALOR IEnumerator***
     ***Ademas del yield retunr WFS, esta el yield return null (son los dos mas usados por los programadores)
     *Si quieres cargar alguna textura o algo de internet y requiere un frame se usa esta corrutina
     *que lo que hace es retrasar la ejecucion de la corrutina 1 frame.
     */
}
