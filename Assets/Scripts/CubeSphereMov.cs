using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSphereMov : MonoBehaviour//Ejercicio1
{
     [SerializeField]
     GameObject spawnC;//Cube

     [SerializeField]
     GameObject spawnS;//Sphere
     




    void Start()
    {
        //Invoke("SpawnCubeSphere", 0.2f);Primera partre del ejercicio
         
        Instantiate(spawnC, transform.position, Quaternion.identity);

        /*Para la ultima parte lo que hay que hacer es referenciar ambos
         prefabs en cada uno de los spawn y poner el Script
        en el GO que queremos de referencia para las posiciones.
        Para la posicion de uno asignaremos un prefab al spawn1 y
        para la del otro en el spawn2 simultaneamente y de forma excluyente,
        por eso haré 2 Scripts, no se me ocurrio otra manera de hacerlo.
        PARA NO HACER 3 SCRIPTS LO QUE PROPONGO ES QUE PARA COMPROBAR,
        EN EL PRIMER SCRIPT SE PONGA EN EL SPAWN2 UN EMPTY*/
    }

    //void SpawnCubeSphere() Primera parte del ejercicio.
    //{
    //    Instantiate(spawnC, new Vector3(-2, 0, 0), Quaternion.identity);
    //    Instantiate(spawnS, new Vector3(2, 0, 0), Quaternion.identity);
    //}    
}
