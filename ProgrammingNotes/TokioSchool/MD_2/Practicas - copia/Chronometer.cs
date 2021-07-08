using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chronometer : MonoBehaviour
{
    public bool pauseChrono;
    public int unoCero;
    public float recordValue;
           int realTime;

    private void Start()
    {
        pauseChrono = true;
        StartCoroutine(SecondCalculate());

    }

    void Update()
    {
        Boton();

    }

    void OnDisable()
    {
        Debug.Log(recordValue + " Son el numero de actualizaciones en el Update");
    }

    //Para congelar usar el checkBox del Inspector.
    public void Boton()
    {
        if (pauseChrono==true)
        {
         unoCero = 1;
            GoTime();

        }

        else
        {
            unoCero = 0;
           
        }
       
    }



    public void GoTime()
    {
        recordValue++;
        Debug.Log(realTime + "  Son los segundos a tiempo real que dura la aplicación activa");

    }

    IEnumerator SecondCalculate()
    {
        realTime += 1;
       yield return new WaitForSeconds(1);//No entiendo por qué no lo hace cada
                                          //segundo
    }
}

