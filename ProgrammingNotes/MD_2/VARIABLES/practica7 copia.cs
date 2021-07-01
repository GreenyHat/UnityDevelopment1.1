using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practica7 : MonoBehaviour

{
    string nombreProgramador;
    string bienvenida = "Hola, profesor, bienvenido";
    int intentosPrueba;
    float coeficicenteSujeto;
    public string pruebaId;
    bool pruebaIdentidad();




    // Start is called before the first frame update
    void Start()
    {


        intentosPrueba = 1;
        coeficicenteSujeto  = 99.9f;
        nombreProgramador = "Jose";
        
       

        pruebaIdentidad(){ //Definir booleano, definir función y en update llamar  función¿¿?

            if (pruebaIdentidad==nombreProgramador){

            Debug.Log("blablabla" + coeficicenteSujeto);
            


            }

            //Joder no me acuerdo!!!!!!!!!!!!!!!!!!!!!!!!!!!






        }
           
           



             
            
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            pruebaIdentidad();

             
        }


        

    }
     







        }
}

