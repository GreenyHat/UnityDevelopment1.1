using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practica16 : MonoBehaviour
{
    public int a=0;
    public int b=1;
    
    
    

    // Start is called before the first frame update
    void Start()
    {
    
    

    }

    // Update is called once per frame
    void Update()
    {
        int temp; /*esto es una variable temporal para
        economizar espacio de memoria, se utiliza 
        una vez y desaparece la variable*/ 
        temp=a;
        a=b;
        b=temp+b;//sucesionDeFibonacci
               /*EXPLICACIÓN*/
        /*   a->0;b->1;[temp->a(1);a(temp)=b->1; b=temp(a)->1+b->b=temp(a)];   */
        
        Debug.Log(temp);

    
        
        Debug.Log(2+3)(srgf);
       

    } 
}
