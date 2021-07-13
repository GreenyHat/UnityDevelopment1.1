using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{//S = s0 + V * t * d

    float verticalInput;
    float speed;

    private void Start()
    {
        speed = 10;
    }

    private void Update()
    {
       

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(speed * Time.deltaTime * Vector3.right);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }
    }
   
}
