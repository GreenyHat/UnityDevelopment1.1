using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasTesting : MonoBehaviour
{

    [SerializeField]
    Button button;

    [SerializeField]
    GameObject cube;

    
    

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FindAndDestroy()
    {
        Destroy(cube, 3.0f);
        GameObject des = GameObject.Find("Cube(Clone)");
        Destroy(des);
    }

    public void InstantiateObject()
    {
        Vector3 rPosition = new Vector3(Random.Range(-97, 106), Random.Range(-170, 130), 124.9f);
        Instantiate(cube, rPosition, Quaternion.identity);
    }
} 
