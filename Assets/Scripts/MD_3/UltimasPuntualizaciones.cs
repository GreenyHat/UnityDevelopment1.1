using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UltimasPuntualizaciones : MonoBehaviour
{
    [SerializeField]
    Rigidbody rB;

    void Start()
    {
        Invoke("BeginRun", 0.3f);//Esta forma de invocar a la funcion es menos optima
        //debido a que la forma de leer las cadenas de caracteres es mas lenta. Mejor utilizar una corrutina
        InvokeRepeating("JumpLoop", 0.4f, 2f);//Este es mas interesante que el invoke el tercer parametro
        //Es para establecer las veces que se repetira
    }
    void Update()
    {
        
    }

    void BeginRun()
    {
        rB.velocity = new Vector3(5, 0, 0);
    }

    void JumpLoop()
    {
        rB.AddForce(new Vector3(0, 170, 0));
    }

    //Repaso de las corrutinas--> TestCoroutine.cs
    //***Si solo voy a poner una linea NO  hace falta abrir llave en los condicionales.
    //private void OnLevelWasLoaded(int level) ES UNA FUNCION QUE TAMBIEN SE TRANSFORMA EN CORRUTINA SI QUEREMOS
    //sirve para ejecutar codigo cuando cargue una determinada escena mediante numeros
    //Las escenas son arrays a nivel interno.
    //si la tenemos asignada en buildSettings. La estructura seria la siguiente:
    private void OnLevelWasLoaded(int level)
    {
        if (level == 0)
        Debug.Log("Aqui va a pasar todo lo que pongamos");
    }




}
