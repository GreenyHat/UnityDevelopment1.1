using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateAndDestroy : MonoBehaviour
{
    /// <summary>
    /// Ejercicio 4
    /// </summary>


    [SerializeField]
    GameObject enemy;
    [SerializeField]
    int enemyCounter = 0;
    [SerializeField]
    bool countFinish;


   

    // Update is called once per frame
    void Update()
    {
         if (enemyCounter < 40 && countFinish==false)
         {

            Vector3 rPosition = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));  
               Instantiate(enemy,rPosition, Quaternion.identity);
               enemyCounter++;
         }

       if (enemyCounter == 40)
       {
            countFinish = true;
       }



    }

    private void LateUpdate()
    {
        DestroyWaitForSeconds();
    }



    void DestroyWaitForSeconds()
       {
        Debug.Log("Estoy pasando");

        if (enemyCounter>0&&countFinish==true)
        {
            enemyCounter--;  
            for (int enemyCount = 40; enemyCount > 0; enemyCount--)
            {
                
                GameObject enemiesDestruibles = GameObject.Find("Enemigo(Clone)");
                
                 Destroy(enemiesDestruibles);
         
            }


        }


        /*A modo de apunte mental para el futuro y a modo de consulta, adjunto lo que creo que serían 
         *otras soluciones para la función destruir que me dio problemas
         *Una podría ser usando Tags y un foreach, como aquí:
         *
         *cubos = GameObject.FindGameObjectsWithTag("Player");
       //Podria servir para el ejercicio del randomizer
       //
       //
       //

       Debug.Log(cubos.Length);
       foreach (GameObject cubo in cubos)
       {
           Destroy(cubo, 1.2f);
       }
        *otro método podría ser con un GetChild y haciendo un contador de los hijos:
        *
        *public GameObject destruibleObjects;
	


		for (int i = 0; i<miTransform.childCount;i++)
		{
		

        destruibleObjects = this.gameObject.transform.GetChild(i).gameObject;
        Destroy(destruibleObjects);

    

         }

 
         */

    }
}

       


           

         



       

      


