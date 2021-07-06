using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CiclosUnity2 : MonoBehaviour
{
    public CiclosUnity refer;
    // Start is called before the first frame update
    void Start()
    {
        refer = GameObject.Find("Cube").GetComponent<CiclosUnity>();
    }

    // Update is called once per frame
    void Update()
    {
       
        ConteoUpd();
        ConteoFix();
        ConteoOn();
    }


    

    public void ConteoUpd()
    {
        refer.upd++;
        
    }

    public void ConteoFix()
    {
        refer.fix++;

    }
    public void ConteoOn()
    {
        refer.ong++;

    }
}
