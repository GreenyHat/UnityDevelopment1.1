using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAndMove2 : MonoBehaviour
{
    [SerializeField]
    GameObject randomSphere;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(randomSphere, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
