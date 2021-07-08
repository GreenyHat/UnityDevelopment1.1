using UnityEngine;

public class practica8 : MonoBehaviour
{
    public int numero1;
    public int numero2;
    public int numero3;


    // Start is called before the first frame update
    void Start()
    {
       numero1=3;
       numero2=5;
        numero3 = (numero1+numero2);
        Debug.Log("El resultado es "+ numero3);

    }

    

    // Update is called once per frame
    void Update() {
        
    }

}  
    