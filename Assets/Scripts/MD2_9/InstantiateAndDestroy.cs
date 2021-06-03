using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateAndDestroy : MonoBehaviour
{
    [SerializeField]
    GameObject enemy;
    [SerializeField]
    int enemyCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (enemyCount<40)
         {

               Vector3 rPosition = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));

                 Instantiate(enemy,rPosition, Quaternion.identity);
                   enemyCount++;
         }


    }
    
}
