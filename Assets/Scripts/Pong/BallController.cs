using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    

   protected Rigidbody2D rB;
 

    void Start()
    {
     
        rB = GetComponent<Rigidbody2D>();
                rB.velocity = new Vector2(3f, 3f);
        
    }

    void Update()
    {
        if (transform.position.x >=9)
        {
          transform.position = new Vector3(0f, 0f, 0f);
        } 
        
        if (transform.position.x <= -9)
        {
           transform.position = new Vector3(0f, 0f, 0f);

        }

    }
}
