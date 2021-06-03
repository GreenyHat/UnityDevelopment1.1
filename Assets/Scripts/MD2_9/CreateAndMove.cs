using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAndMove : MonoBehaviour//Ej_1
{
    [SerializeField]
    GameObject spawnC;//Cube Para la segunda parte del ejercicio en relacion al cubo
                      //referenciar un prefab para poder instanciar
    [SerializeField]
    GameObject spawnS;//Sphere



    void Start()
    {
        Invoke("SpawnCubeSphere", 0.2f);//1ª partre del ejercicio
        Invoke("DestroySphereAndCube", 0.5f);//Ej 2

        //spawnC = Instantiate(spawnC, transform.position, Quaternion.identity);//2ª parte ejer

        /*Para la ultima parte lo que hay que hacer es referenciar ambos
         prefabs en cada uno de los spawn y poner el Script
        en el GO que queremos de referencia para las posiciones.
        Para la posicion de uno asignaremos un prefab a un cubo con este script y
        para la del otro asignaremos CreateAndMove2, simultaneamente y de forma excluyente,
        por eso haré 2 Scripts, no se me ocurrio otra manera de hacerlo.

        PARA NO HACER 3 SCRIPTS LO QUE PROPONGO ES QUE PARA COMPROBAR,
        EN EL PRIMER SCRIPT SE PONGA EN EL SPAWN2 UN EMPTY*/
    }

    //void SpawnCubeSphere() //1ª parte del ejercicio.
    //{
    //    Instantiate(spawnC, new Vector3(-2, 0, 0), Quaternion.identity);
    //    Instantiate(spawnS, new Vector3(2, 0, 0), Quaternion.identity);
    //}

    //void DestroySphereAndCube() //Ej 2
    //{
    //    spawnC = GameObject.Find("Cubo(Clone)");
    //    Destroy(spawnC);
    //    spawnS = GameObject.Find("Esfera(Clone)");
    //    Destroy(spawnS);
    //}
}

