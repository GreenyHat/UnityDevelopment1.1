using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeAndStatusManager : MonoBehaviour
{
    [SerializeField,Tooltip("Número de puntos anotados por player1")]
    protected int score1;

    [SerializeField, Tooltip("Número de puntos anotados por player2")]
    protected int score2;

    [SerializeField]
    protected Text score1Text, score2Text, timeText;

    public float timer;
    bool isFinished;

    private void Start()
    {
        timer = 120f;
    }


    void Update()
    {
        if (isFinished == false) 
        {
            CodeClock();
        }
    }
    void CodeClock()
    {
        timer -= Time.deltaTime;//El valor timer se le resta a los espacios entre frame y frame por lo que tenemos 
                                //un contador cutre


        if (timer <= 0) 
        {
            timer = 0;//Esto es por si hay desfase y hay decimales que se han colado, que me lo ponga en 0 por estetica
            isFinished = true;
        }
        timeText.text = "Tiempo: " + timer.ToString("N2");//El N2 es para que salga el numero de decimales, si ponemos 0, no salen

    }
    
    
}
