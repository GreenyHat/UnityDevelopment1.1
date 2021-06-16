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
}
