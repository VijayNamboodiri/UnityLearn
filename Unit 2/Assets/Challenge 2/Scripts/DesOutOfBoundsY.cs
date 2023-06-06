using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesOutOfBoundsY : MonoBehaviour
{
    public float topBound = 25.0f; //Max distance before destruction    

    //public float bottomBound = -10.0f; //min distance]

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < topBound)
        {
            Destroy(gameObject);
            //SpawnManager.instance.hungryAnimals += 1;


        }
        
    }
}
