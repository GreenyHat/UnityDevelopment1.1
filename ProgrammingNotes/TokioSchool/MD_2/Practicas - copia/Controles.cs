using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controles : MonoBehaviour
{
    public ControlObjeto stop;
    


    private void Start()
    {
        stop = GameObject.Find("Cubo").GetComponent<ControlObjeto>();


        //stop.enabled = false;
    }

}

