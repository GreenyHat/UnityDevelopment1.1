using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : TimeAndStatusManager
{
   protected Rigidbody2D rB;

    [SerializeField, Tooltip("Booleano que permita sacar la pelota de forma FINITA")]
    bool canTakeOut;

    void Start()
    {
        canTakeOut = false;
        rB = GetComponent<Rigidbody2D>();
        rB.velocity = new Vector2(Random.Range(-1f, 1f)-0.5f * 15, Random.Range(-9.4f, 4.9f));
        
    }

    void Update()
    {
        if (transform.position.x >=9)
        {
            rB.velocity = Vector2.zero;
            transform.position = new Vector2(7, 0);
            canTakeOut = true;
           
            
        }
        else if (Input.GetKeyDown(KeyCode.A) && canTakeOut) 
        {
            
            transform.position = Vector3.zero;
            rB.velocity = new Vector2(Random.Range(-1,-1)*15, Random.Range(-5f, 10f));
            score1++;
            score1Text.text = score1.ToString();
            canTakeOut = false;
        }

        if (transform.position.x <= -9)
        {
           transform.position = Vector2.zero;
            rB.velocity = new Vector2(4.5f, 4.5f);
            score2++;
            score2Text.text = score2.ToString();

        }

    }
}
