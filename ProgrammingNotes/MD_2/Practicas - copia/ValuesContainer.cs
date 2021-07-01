using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValuesContainer : MonoBehaviour
{
    /* public Transform med;*/
    float a = 4, b = 4, c = 4;
    public GameObject reference;
   
    void Start()
    {

        /* Transform med = GetComponent<Transform>(); (metodo 1)
         med.position = new Vector3(a, b, c);

         */
        reference.transform.position = new Vector3(a, b, c); //(metodo 2)
    }
   


}
