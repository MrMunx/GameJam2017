using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject worm;
    public float spawnTime;
    public Transform[] spawnPoints;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Spawn()
    {
        //if a certain wave then a certain number of spawn points

        //find random spawn point
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        //make worm
        Instantiate(worm, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

    }
}
