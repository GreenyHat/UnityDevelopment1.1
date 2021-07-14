using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPaddleController : MonoBehaviour
{//S = s0 + V * t * d

    float verticalInput;
    float speed;

    private void Start()
    {
        speed = 10;
    }

    private void Update()
    {
        /*verticalInput = Input.GetAxis("Horizontal");
        transform.Translate(speed * Time.deltaTime * Vector3.right * verticalInput);*/
/*
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(speed * Time.deltaTime * Vector3.right);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(speed * Time.deltaTime * Vector3.left);
        }*/

    }
}

