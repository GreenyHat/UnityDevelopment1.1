using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CiclosUnity : MonoBehaviour
{
    public int upd;
    public int fix;
    public int ong;
    public CiclosUnity2 refer2;

    void Start()
    {
        refer2 = GameObject.Find("Cube").GetComponent<CiclosUnity2>();
        upd = 0;
        fix = 0;
        ong = 0;

    }
    /*Update y fixUpdate empiezan a subir la vez, aparentemente, pero luego va ganando
     velocidad Updaye frente a fixUpdate y OnGui crece de dos en dos por lo que
    la respuesta a qué valor crece más rápido sería OnGui*/

    void Update()
    {
        Stop();
        refer2.ConteoUpd();
    }

    void FixedUpdate()
    {
        refer2.ConteoFix();
    }

    void OnGUI()
    {
        refer2.ConteoOn();
    }

    public void Stop()
    {
        if (upd == 1000 || fix == 1000 || ong == 1000)
        {
            Application.Quit();
        }
    }
}
