using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    WallPool objectPooler;
    public float minSpawnRate;
    public float spawnRate;
    public float spawnDelayDropSpeed = 0.1f;
    public float spawnDelayDeceleration = 0.1f;

    float lastSpawnTime;
    float accumulatedTime;

    void OnEnable()
    {
        accumulatedTime = 0f;
        lastSpawnTime = 0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        objectPooler = WallPool.INSTANCE;
    }

    void Update()
    {
        accumulatedTime += Time.deltaTime;

        spawnDelayDropSpeed += spawnDelayDeceleration * Time.deltaTime;
        spawnRate = Mathf.Max(spawnRate - Time.deltaTime * spawnDelayDropSpeed, minSpawnRate);

        if (accumulatedTime - lastSpawnTime > spawnRate)
        {
            lastSpawnTime = accumulatedTime;
            objectPooler.SpawnFromPool("Wall", transform.position, Quaternion.identity);
            Spawn();
        }            
    }

    void Spawn()
    {
        Debug.Log("Spawned at " + accumulatedTime);
    }
}
