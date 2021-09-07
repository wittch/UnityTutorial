using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 2;
    private float spawnInterval = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }
    void Update()
    {
        
        
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
                
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int selectRandomBall = Random.Range(0, ballPrefabs.Length);
        // instantiate ball at random spawn location
        spawnInterval = Random.Range(3, 5);
        Instantiate(ballPrefabs[selectRandomBall], spawnPos, ballPrefabs[selectRandomBall].transform.rotation);
    }

}
