using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practica17 : MonoBehaviour
{
    public float datoAEvaluar;
    float porcentaje25;
    float porcentaje50;
    float porcentaje75;
    // Start is called before the first frame update
    void Start()
    {
        porcentaje25= datoAEvaluar*0.25f;
        porcentaje50= datoAEvaluar*0.50f;
        porcentaje75= datoAEvaluar*0.75f;
       

         Debug.Log(porcentaje25 + " Es el 25% de " + datoAEvaluar + " el 50% " + porcentaje50 + " y este, el 75% --> " + porcentaje75 + " cuando llegue a 100 el PC colapsará :) " );
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
