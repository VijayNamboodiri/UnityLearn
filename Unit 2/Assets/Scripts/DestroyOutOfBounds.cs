using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 25.0f; //Max distance before destruction    

    public float bottomBound = -10.0f; //min distance


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound || transform.position.z < bottomBound)
        {
            Destroy(gameObject);    
        }
    }
}
