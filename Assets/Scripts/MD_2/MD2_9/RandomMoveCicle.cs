using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMoveCicle : MonoBehaviour
{
    //[SerializeField]
    //bool isPositive;
    [SerializeField]
    GameObject cube;
    [SerializeField]
    bool firstMove;
    float speed;


    /// <summary>
    /// Ejercicio 6
    /// No tengo muy claro cómo hacer lo que me pedia el ejercicio. 
    /// </summary>


    void Start()
    {
        firstMove = true;
    }

    void Update()
    {
        if (firstMove == true)
        {
           cube.transform.Translate(Random.Range(1.4f, 8.7f), Random.Range(-2.2f,0.81f ), 0);
           firstMove = false;
        }
              
    }

    //private void OnBecameInvisible()
    //{
    //    if (transform.position.x > 11 && firstMove == false)
    //    {
    //        transform.Translate(Vector3.left*speed*Time.deltaTime * Random.Range(10, 15));
    //    }

    //    //if (transform.position.y >= 0 && firstMove == false)
    //    //{
    //    //    transform.Translate(1, 0, 0);
    //    //}
        
    //}







    //private void OnBecameInvisible()
    //{
    //    if (transform.position.x >= 0 && firstMove == false)
    //    {
    //        isPositive = true;
    //    }
    //    else if (transform.position.x >= 0 && isPositive == true)
    //    {
    //        transform.Translate(-1, 0, 0);
    //    }
    //    else
    //    {
    //        transform.Translate(1, 0, 0);

    //    }


    //    if (transform.position.y >= 0 && firstMove == false)
    //    {
    //        isPositive = true;
    //    }
    //    else if (transform.position.y >= 0 && isPositive == true)
    //    {
    //        transform.Translate(0, -1, 0);
    //    }
    //    else
    //    {
    //        transform.Translate(0, 1, 0);

    //    }
    //}






    //private void OnBecameVisible()
    //{
    //    if (cube.transform.position.x <= 11 && isPositive == false)
    //    {
    //        cube.transform.Translate(1, 0, 0);
    //    }

    //    else if (cube.transform.position.y <= 4.6f && isPositive == false)
    //    {
    //        cube.transform.Translate(0, 1, 0);

    //    }

    //    else
    //    {
    //        isPositive = true;
    //    }
    //}




    //void OnBecameInvisible()
    //    {
    //       if (cube.transform.position.x >= 11 && isPositive == true)
    //       {
    //        cube.transform.Translate(-1, 0, 0);
    //       }

    //       else if (cube.transform.position.y >= -2.2f && isPositive == true)
    //       {
    //        cube.transform.Translate(0, -1, 0);

    //       }

    //       else
    //       {
    //        isPositive = false;

    //       }
    //}
}
