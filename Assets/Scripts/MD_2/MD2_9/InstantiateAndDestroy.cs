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

        

       }
}

       


           

         



       

      


