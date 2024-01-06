using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject Drone;
    private GameObject DroneSpawn;

    // Start is called before the first frame update
    void Start()
    {
        
        //DroneSpawn();
        float spawnTime = 5f;
        InvokeRepeating("SpawnRandom", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnRandom()
    {
       

        Vector3 screenPosition = Camera.main.ScreenToWorldPoint(new Vector3(UnityEngine.Random.Range(10, Screen.width -10), UnityEngine.Random.Range(10, Screen.height -10), Camera.main.farClipPlane / 2));
        DroneSpawn = Instantiate(Drone, screenPosition, Quaternion.identity);
    }
 
}