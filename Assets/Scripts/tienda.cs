using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Ejercicio 15

/*string[] productosTienda={"Leche","Huevos","Carne","Mantequilla","Sobrasada"};
    // Start is called before the first frame update
    void Start()
    {
        if (productosTienda[0]=="Leche" || productosTienda[1]=="Leche"||productosTienda[2]=="Leche"
         ||productosTienda[3]=="Leche"||productosTienda[4]=="Leche")
        {
           Debug.Log("Tenemos leche en la tienda");
        }
*/

public class tienda : MonoBehaviour
{
    string[] productosTienda={"Leche","Soja","Carne","Huevos"};
    public string tipoDeTienda;
    // Start is called before the first frame update
    void Start()
    {


        if (tipoDeTienda==productosTienda[0])
        {
            Debug.Log("Es una tienda de prodictos lácteos");
        }

        else if(tipoDeTienda==productosTienda[3])
        {

            Debug.Log("Es una tienda de huevos");
        }

        else if(tipoDeTienda==productosTienda[0] && tipoDeTienda == productosTienda[3])
        {
            Debug.Log("Es una tienda mixta");
        }
        else
        {
            Debug.Log("Es otro tipo de tienda");
        }



           

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


