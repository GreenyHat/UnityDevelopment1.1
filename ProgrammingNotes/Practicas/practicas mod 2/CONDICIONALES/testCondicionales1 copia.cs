using System.Collections;
using System.Collections.Generic;
using UnityEngine;













   /////////////////////////////
  ///////////EJERCICIO 1///////
  ////////////////////////////

/* if (name=="Toni")
        {
            Debug.Log("Efectivamente, es correcto");
        }





      //////////////////////////////
      ///////////EJERCICIO 2///////
      ////////////////////////////

      Si cambiamos una letra minuscula por mayuscula no lo admite porque el programa lo entienden como una
      cadena de caracteres nueva y habria que definirla en el condicional con un if else.





        */









public class testCondicionales1 : MonoBehaviour
{
    public string name;
    // Start is called before the first frame update
    void Start()

    {
        if (name=="Toni")
        
        {
            Debug.Log("Efectivamente, es correcto");
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
