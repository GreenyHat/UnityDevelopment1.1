using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawn;
    public GameObject tempSpawn;
    //public Transform SpawnTransform;
    // Start is called before the first frame update
    void Start()
    {
        //SpawnTransform = GetComponent<Transform>();

        Invoke("SpawnEnemy", 1f);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemy()
    {
      tempSpawn = Instantiate(spawn, new Vector3(0, 0, 0), Quaternion.identity);
      Invoke("SpawnEnemy", 1f);

        StartCoroutine(DestroyCourutine());
    }

    IEnumerator DestroyCourutine()
    {
        yield return new WaitForSeconds(1.8f);
        Destroy(tempSpawn);
    }
}
