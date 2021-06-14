using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove2 : MonoBehaviour
{
    public float xMove;
    public float yMove;
    public bool firstMove;
    void Start()
    {
        firstMove = true;
        xMove = transform.position.x;
    }

    void Update()
    {
        if (firstMove==true)
        {
          transform.Translate(Vector3.right*Time.deltaTime);

        }

    }
 
    private void OnBecameInvisible()//Cómo hago que se mueva frame a frame?? 
    {
       
        
         firstMove = false;
        
        if (firstMove==false)
        {
            transform.Translate(Vector3.left);

        }
    }
    void TranslateLeft()
    {
        transform.Translate(Vector3.left);

    }
}
