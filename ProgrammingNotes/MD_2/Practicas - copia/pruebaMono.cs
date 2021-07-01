using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebaMono
{}
/*En cuanto al ejercicio 7 lo que sucede es que no se puede anadir
 porque no hereda de Unity y por tanto no cuenta con su coleccion de funciones, clases... 
Sin embargo lo que si se podria hacer es hacer una clase padre con la que actuasemos en el editor 
y otras clases hijas que utilizaríamos para acceder a propiedades descritas en esos scripts 
que no deben necesariamente heredar de monobehaviour. Por ejemplo: */


///////////////////////////Ejemplo practico/////////////////////////////////////////////

/*public class CampoBatalla : MonoBehaviour
{
    Enemigos enemy1;
    Enemigos enemy2;
    Enemigos enemy3;
    // Start is called before the first frame update
    void Start()
    {
        CrearEnemigo1();
        CrearEnemigo2();
        CrearEnemigo3();
    }

    void CrearEnemigo1()
    {
        enemy1 = new Enemigos();
        enemy1.raza.duende = "es un duende";
        print("El primer enemigo " + enemy1.raza.duende + " y tiene la siguientes habilidades: ");
        enemy1.arma.magia.PoderFuego();
    }

    void CrearEnemigo2()
    {
        enemy2 = new Enemigos();
        enemy2.arma.espeada = "usa una espada";
        enemy2.raza.babaduende = "es un babaduende, por tanto un enemigo lento, pues suelen ir borrachos y cansados";
        print("El segundo enemigo " + enemy2.raza.babaduende + " y " + enemy2.arma.espeada);

    }

    void CrearEnemigo3()
    {
        enemy3 = new Enemigos();
        enemy3.raza.elfo = "Es un elfo, por tanto un gilipollas pijo y un soplapollas engreído";
        enemy3.arma.magia.PoderHielo();
    }

}*/  //Aquí tendriamos la clase padre y los hijos a los que accedemos como propiedades, hechos en 
//scripts a parte, como "arma","poder", "raza"...