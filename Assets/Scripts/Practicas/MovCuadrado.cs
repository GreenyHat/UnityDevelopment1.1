using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCuadrado : MonoBehaviour
{
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y <= 1 && transform.position.x > 6)
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);

        }

        else if (transform.position.y < 9 && transform.position.x <= 7)
        {
            transform.Translate(Vector3.up * velocidad * Time.deltaTime);

        }

        else if (transform.position.y >= 9 && transform.position.x < 7)
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);

        }


        else if (transform.position.x > 6)
        {
            transform.Translate(Vector3.down * velocidad * Time.deltaTime);
        }

    }
}
