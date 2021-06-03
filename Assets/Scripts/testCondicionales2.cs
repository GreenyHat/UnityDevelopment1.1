





using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCondicionales2 : MonoBehaviour
{


     int tempInd=0;
     bool mulitplo2;
     public int ciclos=0;
     public int counter;
     bool up=true;
     public int sumNumbers;
     public int wheels;
     public string[] edificio2;
     string[] edificio1={"Antonio","Jose","Juan","Maria","Fatima","Julian","Jose","Jesus","Julio","Lola","Enrique","Chiara","Luiggi",
     "Alberto","Gonzalo","Patricia"};
     
     int antonios = 0;

     int coincidencias=0;
     int o=0;


    int limit = 25;
    int numeroDivision;
    int vecesDivisible;
    public int [] numbers = new int [25]{2,7,3,5,34,6,877,65,43,32,67,78,66,99,26,17,16,29,27,27,37,20,33,45,67};
    int i;
    
    // Start is called before the first frame update
    void Start()
    {

       /* 

/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO1//////////
//////////////////////////////////
/////////////////////////////////

while (counter<100)
        {
            counter++;
        }
        
        
/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO2//////////
//////////////////////////////////
/////////////////////////////////
        
        
        while (counter<1000)
        {
         
           counter++;
           En realizar el bucle no tarda ni un segundo, Unity no se molesta en mostrar frame por frame la operación,
           por lo que aparece directamente el 1000 en microsegundos

        }
        

/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO3//////////
//////////////////////////////////
/////////////////////////////////

        while (counter>0)
       {
           counter--;
       }
        
        
 /////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO5//////////
//////////////////////////////////
/////////////////////////////////       

  while (counter<5000)
       {
           counter+=3;
           Debug.Log(counter);// esto lo he puesto para hacer comprobaciones
        
        }



/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO6//////////
//////////////////////////////////
/////////////////////////////////       




        while (counter<5000)
       {
           counter+=3;
           Debug.Log(counter);// Utilizo la mismna variable con un debug
        
        }




/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO7//////////
//////////////////////////////////
/////////////////////////////////


  foreach (int indicesMultiplos2 in numbers)//No he sido capaz de ver cómo aplicar While en este ejercicio
    {
        if (indicesMultiplos2%2==0)
        {
            Debug.Log(indicesMultiplos2);
        }
        
        
    }
    
/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO8//////////
//////////////////////////////////
/////////////////////////////////


    foreach (int indicesMultiplos2 in numbers) //Cómo cambio el orden de recorrido del array¿? 
    {
        if (indicesMultiplos2%3==0)
        {
            Debug.Log("Estos son multiplos de 3: "+indicesMultiplos2);
        }
        
        else if (indicesMultiplos2%5==0){

            Debug.Log("Estos son multiplos de 5: "+indicesMultiplos2);   
        }
    }
  


  /////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO9//////////
//////////////////////////////////
/////////////////////////////////


 foreach (int indice in numbers)
    {
        int temp1=indice*10;
        int temp2=temp1+temp1;
        
        


        Debug.Log("Esta es la multiplicación: "+ temp1);
        Debug.Log("Esta es la suma: "+ temp2);
    }


/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO12//////////
//////////////////////////////////
/////////////////////////////////

        
     while (i < limit)/////////CÓDIGO IMPORTANTE PARA RECORDAR SU LÓGICA/////////////////
        {
            i++;

            while (numeroDivision < i)
            {
                numeroDivision++;

                if (i % numeroDivision == 0)
                {
                    vecesDivisible++;
                }
            }

            if (vecesDivisible == 2)
            {
                Debug.Log(i + " es un número primo");
            }

            numeroDivision = 0;
            vecesDivisible = 0;
        }



/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO13/////////
//////////////////////////////////
/////////////////////////////////



/////////////////////////APUNTES MENTALES PARA MI YO DEL FUTURO***¡¡GRACIAS RUBÉN!!***\/////////////////////////
     // Vars de clase:
     // antonios=0 partimos de que no hay Antonios, porque no se ha empezado a comprobar
     // i=0 esto define el numero del indice en el que empieza a comprobar

        
        while(i < edificio1.Length)//aqui decimos que mientras el indice sea menor a la longitud del array ejecute el código de abajo
        {
            if (edificio1[i].Equals("Antonio")) //la funcion .Equals es lo mismo que ==,,, por eso, al ser funcion, se pone --> ()
                antonios++;//aqui incrementamos el numero de antonios si es que lo encuentra en la primera orden
            i++;//y seguimos comprobando indices
        }
        if (antonios == 1)//se empieza a comprobar si hay Antonios

            Debug.Log("He encontrado a Antonio");

        else if(antonios > 1)
            Debug.Log("He encontrado a los Antonios");

        else
            Debug.Log("No hay ningún Antonio en este edificio");








/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO14/////////
//////////////////////////////////
/////////////////////////////////



intento 1:////////////////////

  while (i<edificio1.Length && o<edificio2.Length)
{

i++; o++;

    if (edificio2[o] == edificio1[i])
        
    
        coincidencias++;
       
        
    

     if (coincidencias>=1)
    {
        Debug.Log("Tenemos coincidencias en los edificios");
        
    
    }

    else
    
        Debug.Log("No hay coincidencias en el edificio");




intento2://////////


  while (i<edificio1.Length && o<edificio2.Length)
{
        

   for (int i = 0; i < edificio1.Length; i++)
    {
    

       if (i==o)
        {



           coincidencias++;
        }
     
     
        else if (coincidencias>=1)
       {
          Debug.Log("Hay coincidencias");
       }
       break;

    }


    if (i>o)
   { 
       o++;
   }

  if (i==edificio1.Length && o==edificio2.Length)
   {
     break;
    }
     



    else
    {
        Debug.Log("No hay coincidencias");
    }

    
}





}}



/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO15/////////
//////////////////////////////////
/////////////////////////////////




switch (wheels)
  {
      case 1:
      Debug.Log("Es monociclo");
      break;

      case 2:
      Debug.Log("Es moto");
       break;

      case 3: 
      Debug.Log("triciclo");
      break;

      case 4:
      Debug.Log("coche");
       break;

        default: 
      
      Debug.Log("No tienes informacion sobre el vehiculo");
      break; 

  }



/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO18.1///////
//////////////////////////////////
/////////////////////////////////






 for (counter=0;counter<100;counter++)
 {
    

 }









/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO18.2///////
//////////////////////////////////
/////////////////////////////////

 for ( counter = 0; counter < 1000; counter++)
  {
   //igual que en los primeros efercicios tarda menos de un segundop, porque el editor ni siquiera se molesta en exponerlos 
   //1 a 1   
  }

/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO18.3///////
//////////////////////////////////
////////////////////////////////

for ( counter = 10000; counter > 0; counter--)
  {
   
  }
  

/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO18.5///////
//////////////////////////////////
/////////////////////////////////


for ( counter = 0; counter < 5000; counter+=3)
  {
   Debug.Log(counter);
  }
  


/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO18.6///////
//////////////////////////////////
/////////////////////////////////

for ( counter = 0; counter < 5000; counter+=3)
  {

      
      if (counter<5000)
      {
          ciclos++;
      }

   }   








/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO18.7///////
//////////////////////////////////
////////////////////////////////

 for ( i = 0; i <numbers.Length; i++)
   {
       int [] numbers = new int [25]{2,7,3,5,20,6,877,65,43,32,67,78,66,99,26,17,16,29,27,27,37,20,33,45,67};
      

      if (numbers[i]%2==0)
        {

          Debug.Log(numbers[i]+" Es multiplo de 2.");

        }

        else
        {
            Debug.Log(numbers[i]+" No es multiplos de 2");
        }
   }




/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO18.8///////
//////////////////////////////////
/////////////////////////////////


 for ( i = numbers.Length -1; i > 0; i--)
   {
       int [] numbers = new int [25]{2,7,3,5,20,6,877,65,43,32,67,78,66,99,26,17,16,29,27,27,37,20,33,45,67};
      

      if (numbers[i]%3==0)
        {

          Debug.Log(numbers[i]+" Es multiplo de 3 ");

        }


        if (numbers[i]%5==0)
        {
            Debug.Log(numbers[i]+" Es multiplo de 5");
        }
    }    




/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO18.9///////
//////////////////////////////////
/////////////////////////////////




int [] numbers = new int [25]{2,7,3,5,20,6,877,65,43,32,67,78,66,99,26,17,16,29,27,27,37,20,33,45,67};
      



       

     foreach (int indice in numbers)
    {
        int temp1=indice*10;

        
    
        


        Debug.Log("Esta es la multiplicación: "+ temp1);

        

     
    }
    
    int suma=numbers[0]+numbers[1]+numbers[2]+numbers[3]+numbers[4]+numbers[5]+numbers[6]+numbers[7]+numbers[8]+numbers[9]+numbers[10]
        +numbers[11]+numbers[12]+numbers[13]+numbers[14]+numbers[15]+numbers[16]+numbers[17]+numbers[18]+numbers[19]+numbers[20]
        +numbers[21]+numbers[22]+numbers[23]+numbers[24];


      Debug.Log("Esta es la suma: "+ suma);







/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO18.12///////
//////////////////////////////////
/////////////////////////////////



 for (int i = 0; i < 25; i++)
   {
            while (numeroDivision < i)
            {
                numeroDivision++;

                if (i % numeroDivision == 0)
                {
                    vecesDivisible++;
                }
            }

            if (vecesDivisible == 2)
            {
                Debug.Log(i + " es un número primo");
            }

            numeroDivision = 0;
            vecesDivisible = 0;
        }
    }







/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO18.13///////
//////////////////////////////////
/////////////////////////////////






  

 

    

*/
 
  
         


   
  
    for (int i = 0; i < edificio1.Length; i++)
    {
      
        if (edificio1[i]=="Antonio")
        {
          
          antonios++;
        }


        

    }

      
    
        if (antonios==1)
        {
            Debug.Log("Hay un Antonio en el edificio.");
        }
        
        if (antonios>1)
        {
            Debug.Log("Hay más de un Antonio en el edificio");
        }






  
  

 













            

    







void Update() 
{
  /*  
  
  
  
/////////////////////////////////////
////////////////////////////////////
///////////////EJERCICIO16/////////
//////////////////////////////////
/////////////////////////////////
  
  
  
  
  
  switch (sumNumbers)
{
    case 0: 
    sumNumbers=0+1;
    
        break;

    case 1:
    sumNumbers=1+1;
        break;


    case 2:
    sumNumbers=2+1;
        break;

    
    case 3:
     sumNumbers=3+1;
         break;

    case 4:
     sumNumbers=4+1;

         break;

    case 5:
    sumNumbers=5+1;
        break; 
    
    
    case 6:
    sumNumbers=6+1;
        break;

    case 7:
    sumNumbers=7+1;
        break;

    case 8:
    sumNumbers=8+1;
        break;

    case 9:
    sumNumbers=9+1;
        break;

    case 10:
    sumNumbers=10+1;
        break;


    
    default:
    sumNumbers=0;
    
    break;
    
}




//intento de ejercicio 17: He intentado resolverlo, durante unas 2 horas y ha sido frustrante. ( más abajo está el resultado con ayuda)
while (sumNumbers>0)
    {

switch (sumNumbers)
{
    
        
    
    case 0: 
    if (sumNumbers==0)
    {
        sumNumbers=0;
    }

    
    
        break;

    case 1:

    sumNumbers=1-1;
        break;


    case 2:
    sumNumbers=2-1;
        break;

    
    case 3:
     sumNumbers=3-1;
         break;

    case 4:
     sumNumbers=4-1;

         break;

    case 5:
    sumNumbers=5-1;
        break; 
    
    
    case 6:
    sumNumbers=6-1;
        break;

    case 7:
    sumNumbers=7-1;
        break;

    case 8:
    sumNumbers=8-1;
        break;

    case 9:
    sumNumbers=9-1;
        break;

    case 10:
    sumNumbers=10-1;

    

    break;





        

   
    
}

    }






Ejercicio 17 resuelto con sugerencia de Ruben


if (up==true)
{
    sumNumbers++;
}
else
{
    sumNumbers--;
}



switch (sumNumbers)
{
    
    
    case 0: 
    sumNumbers=0;
    up=true;
        break;

    case 1:
    sumNumbers=1;
        break;


    case 2:
    sumNumbers=2;
        break;

    
    case 3:
     sumNumbers=3;
         break;

    case 4:
     sumNumbers=4;

         break;

    case 5:
    sumNumbers=5;
        break; 
    
    
    case 6:
    sumNumbers=6;
        break;

    case 7:
    sumNumbers=7;
        break;

    case 8:
    sumNumbers=8;
        break;

    case 9:
    sumNumbers=9;
        break;

    case 10:
    sumNumbers=10;
        break;
    

default:

up=false;
sumNumbers=10;
sumNumbers=9;

break;


    
   
}









    






*/










}


}
}








  



















   

    



    
     
     
   












 








    

    



    

   

  

