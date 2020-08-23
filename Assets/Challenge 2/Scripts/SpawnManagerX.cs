﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private int indexBall;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomBall", startDelay);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY,0);

        indexBall = Random.Range(0, ballPrefabs.Length);
        


        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[indexBall], spawnPos, ballPrefabs[0].transform.rotation);

        startDelay = Random.Range(3.0f, 5.0f);
        Invoke("SpawnRandomBall", startDelay);
    }

}