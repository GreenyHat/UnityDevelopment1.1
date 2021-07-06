using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuevoTestMono : MonoBehaviour
{
    private void OnDisable()
    {
        print("probando disable2");
    }

    private void OnDestroy()
    {
        print("probando destroy 2"); 
    }
}
/*Los eventos Awake, Start y OnEnable se ejecutan con normalidad, Ondestroy se ejecuta tanto cuando se suprime desde 
 hierarchy como cuando paramos la ejecucion (es decir cuando pulsamos pause) y no suprimimos*/