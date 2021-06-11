using UnityEngine;
using System.Collections;

public class DisableAndDestroy : MonoBehaviour
{
    /// <summary>
    /// Ejercicio 5
    /// </summary>

    [SerializeField]
    GameObject enemy;
    [SerializeField]
    GameObject[] enemies;
    [SerializeField]
    int enemyCounter = 0;
    [SerializeField]
    bool countFinish;
   

    private void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Player");
    }

    void Update()
    {
        if (enemyCounter < 40 && countFinish == false)
        {

            Vector3 rPosition = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            Instantiate(enemy, rPosition, Quaternion.identity);
            enemyCounter++;
            
        }

        if (enemyCounter == 40)
        {
            countFinish = true;
        }

        if (countFinish==true&&enemyCounter>0)
        {
            enemyCounter--;
            GameObject enemyBox = GameObject.Find("Enemigo(Clone)");
            enemyBox.SetActive(false);
            Destroy(enemyBox,1.5f);
            
        }

        
    }
}
    