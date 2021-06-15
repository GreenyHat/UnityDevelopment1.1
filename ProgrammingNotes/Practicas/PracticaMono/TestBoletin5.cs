using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBoletin5 : MonoBehaviour
{
    private GameObject miCubo;
    [SerializeField]
    private Rigidbody uno;//Ej4
    [SerializeField]
    private Rigidbody dos;//Ej4
    private void Awake()
    {
        /*   if (miCubo = GameObject.FindGameObjectWithTag("Player"))//Ej3

           {

               print("He encontrado el objeto " + miCubo);

           }*/
    }

    // Start is called before the first frame update
    void Start()
    {
        //miCubo.transform.localScale = new Vector3(3, 3, 3);//Ejercicio1Y2
        //en el 1 sería habiendo arrastrado el objeto desde la jerarquía a la variable publica miCubo


        /////////////////////////////////////////////////////////////////////////////
        //////////////////////////////// Ej4 ////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////

        /*    uno = GetComponent<Rigidbody>();
            uno.mass = dos.mass;*/


    }


}
