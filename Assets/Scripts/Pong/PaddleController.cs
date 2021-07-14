using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{//S = s0 + V * t * d

    //float verticalInput;
    float speed;
    [SerializeField, Tooltip("Player controller managers")]
    GameObject player1, player2;

    private void Start()
    {
        speed = 10;
    }

    private void Update()
    {
        /*verticalInput = Input.GetAxis("Horizontal");
     transform.Translate(speed * Time.deltaTime * Vector3.right * verticalInput);*/


        if (Input.GetKey(KeyCode.UpArrow))
        {
            player1.transform.Translate(speed * Time.deltaTime * Vector3.right);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            player1.transform.Translate(speed * Time.deltaTime * Vector3.left);
        }
        if (Input.GetKey(KeyCode.W))
        {
            player2.transform.Translate(speed * Time.deltaTime * Vector3.right);

        }
        else if (Input.GetKey(KeyCode.S))
        {
            player2.transform.Translate(speed * Time.deltaTime * Vector3.left);
        }

        ///Esto establece un limite en las raquetas para que no sobrepase X punto en Y.
        player1.transform.position = new Vector2(player1.transform.position.x, Mathf.Clamp(player1.transform.position.y, -2.86f, 4.85f));
        player2.transform.position = new Vector2(player2.transform.position.x, Mathf.Clamp(player2.transform.position.y, -2.86f, 4.85f));
    }
   
}
