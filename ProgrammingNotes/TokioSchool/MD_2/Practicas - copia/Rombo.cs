using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rombo : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, 0, -40);
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < 7)
        {
            transform.Translate(Vector3.up);
        }



        if (transform.position.y >= 7)
        {
            transform.Rotate(0, 0, -220);
            transform.Translate(Vector3.up);

        }

        else if (transform.position.x > 30)
        {

            //transform.Translate(Vector3.right);
            transform.Rotate(0, 0, 400);

        }







    }








}
