using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveStatusTest : MonoBehaviour
{
    void Start()
    {

        if (PlayerPrefs.HasKey("MaxScore")==false)// tambien seria valido if (!PlayerPrefs.HasKey("MaxScore"))
        {
          PlayerPrefs.SetInt("MaxScore", 0);
        }

        if (!PlayerPrefs.HasKey("ActualStage"))
        {
            PlayerPrefs.SetInt("ActualStage", 1);
        }

        if (PlayerPrefs.HasKey("PlayerName")==false)
        {
            PlayerPrefs.SetString("PlayerName", "Link");/*Imaginemos que estamos en el Zelda
                                                         y nos piden introducir nombre para rol
            si no ponemos ninguno pues es el que se le asigne, en este caso Link*/
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log(PlayerPrefs.GetString("PlayerName"));//Aqui me devuelve la key PN que es link
        }

        if (Input.GetKey(KeyCode.S))
        {
            PlayerPrefs.SetString("PLayerName", "Zelda");//Esto me actualiza la clave PN de Link a Zelda
        }
    }
}
