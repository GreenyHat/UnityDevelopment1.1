using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangulottt : MonoBehaviour
{
    public float speed;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

       



            if (transform.rotation.z < 40.00f)

            {
                //transform.Translate(Vector3.up * speed * Time.deltaTime);
                transform.Rotate(0, 0, 2.5f * speed * Time.deltaTime);
            }

       


        // if (transform.position.y < 9&& transform.position.x<=7)
        //{
        //   transform.Translate(Vector3.up * velocidad * Time.deltaTime);

        //}

        //else if (transform.position.y >=9&&transform.position.x < 7)
        //{
        //   //transform.rotation = new Quaternion(1, 1, 0, 0);
        //   transform.Rotate(0, 0, 2);
        //   transform.Translate(Vector3.up * velocidad * Time.deltaTime);
        //   transform.Rotate(0, 0, 4);
        //   transform.Translate(Vector3.up * velocidad * Time.deltaTime);

    }
         


        //else if (transform.rotation.x<0)
        //{
        //    transform.Translate(Vector3.down * velocidad * Time.deltaTime);
        //}



    


         
    

}
       

