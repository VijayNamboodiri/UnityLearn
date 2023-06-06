using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float shootDelay = .5f;    
    float timeOfLastShot;

    void start()
    {
        timeOfLastShot = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        if(timeOfLastShot + shootDelay < Time.time)
        {
            
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timeOfLastShot = Time.time;
            }
            
        }
        
        
    }
}
