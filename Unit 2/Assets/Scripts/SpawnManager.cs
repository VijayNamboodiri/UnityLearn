using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    public float startDelay = 2;
    public float spawnInterval = 1.5f;
    public int animalsFed = 0;
    public int hungryAnimals = 0;
    public GameObject lossScreen;

    public GameObject winScreen;
    
    public static SpawnManager instance;

    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnAnimal", startDelay, spawnInterval);
        winScreen.SetActive(false);
        lossScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(animalsFed == 5)
        {
            CancelInvoke("SpawnAnimal");
            winScreen.SetActive(true);
        }
    }


    public void SpawnAnimal()
    {
          
        int animalIndex = Random.Range(0,animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0, spawnPosZ);
            
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}

